using AutoMapper;
using DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using TradeCompany.Database;

namespace TradeCompanyDAL
{
    public class SupplierDAL : TradeCompanyEntities
    {
        readonly IMapper _mapper;
        public SupplierDAL()
        {
            var config = new MapperConfiguration(c =>c.AddProfiles(typeof(SupplierDAL)));
            _mapper = config.CreateMapper();
        }
        public List<SupplierDTO> GetSuppliers()
        {
            using (var db = new SupplierDAL())
            {
                var sups = db.tblSuppliers
                    .Where(x => x.isBlocked == false)
                    .ToList();
                return _mapper.Map<List<SupplierDTO>>(sups);
            }
        }

        public List<SupplierDTO> SortSuppliers(List<SupplierDTO> suppliers, int type)
        {
            switch (type)
            {
                case 1:
                    return suppliers.OrderBy(x => x.name).ToList();
                case 2:
                    return suppliers.OrderByDescending(x => x.name).ToList();
                case 3:
                    return suppliers.OrderBy(x => x.rating).ToList();
                case 4:
                    return suppliers.OrderByDescending(x => x.rating).ToList();

                default:
                    return suppliers;
            }
        }

        public List<SupplierDTO> GetBlockedSuppliers()
        {
            using (var db = new SupplierDAL())
            {
                var sups = db.tblSuppliers
                    .Where(x => x.isBlocked == true)
                    .ToList();
                return _mapper.Map<List<SupplierDTO>>(sups);
            }
        }

        public int UnblockById(int id)
        {
            using (var db = new SupplierDAL())
            {
                var result = db.tblSuppliers.SingleOrDefault(p => p.supplierId == id);
                if (result != null)
                {
                    result.isBlocked = false;
                    db.SaveChanges();
                    return result.supplierId;
                }
                return 0;
            }
        }

        public int BlockById(int id)
        {
            using (var db = new SupplierDAL())
            {
                var result = db.tblSuppliers.SingleOrDefault(p => p.supplierId == id);
                if (result != null)
                {
                    result.isBlocked = true;
                    db.SaveChanges();
                    return result.supplierId;
                }
                return 0;
            }
        }

        public SupplierDTO GetSupplierById(int id)
        {
            using (var db = new SupplierDAL())
            {
                return _mapper.Map<SupplierDTO>(db.tblSuppliers.FirstOrDefault(p => p.supplierId == id));
            }
        }

        public SupplierDTO GetSupplierByName(string name)
        {
            using (var db = new SupplierDAL())
            {
                var supplier = db.tblSuppliers
                    .Where(p => p.name == name)
                    .FirstOrDefault();
                return _mapper.Map<SupplierDTO>(supplier);
            }
        }

        public int AddSupplier(SupplierDTO supplier)
        {
            if (supplier != null)
            {
                using (var db = new SupplierDAL())
                {
                    db.tblSuppliers.Add(_mapper.Map<tblSupplier>(supplier));
                    db.SaveChanges();
                    return supplier.supplierId;
                }
            }
            return 0;
        }

        public int DeleteSuppliersById(int id)
        {
            using (var db = new SupplierDAL())
            {
                var provider = _mapper.Map<tblSupplier>(GetSupplierById(id));

                if (provider != null)
                {
                    db.Entry(provider).State = EntityState.Deleted;
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
        }
        
    }
}
