using AutoMapper;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using TradeCompany.Database;

namespace TradeCompanyDAL
{
    public class SupplierDAL : TradeCompanyEntities
    {
        IMapper _mapper;
        public SupplierDAL()
        {
            var config = new MapperConfiguration(c=>c.AddProfiles(typeof(SupplierDAL)));
            _mapper = config.CreateMapper();
        }
        public List<tblSupplier> GetSuppliers()
        {
            using (var db = new SupplierDAL())
            {

                return db.tblSuppliers
                    .Where(x => x.isBlocked == false)
                    .ToList();
            }
        }

        public List<tblSupplier> SortSuppliers(List<tblSupplier> supplier, int type)
        {
            switch (type)
            {
                case 1:
                    return supplier.OrderBy(x => x.name).ToList();
                case 2:
                    return supplier.OrderByDescending(x => x.name).ToList();
                case 3:
                    return supplier.OrderBy(x => x.rating).ToList();
                case 4:
                    return supplier.OrderByDescending(x => x.rating).ToList();

                default:
                    return supplier;
            }

        }

        public List<tblSupplier> GetBlockedSuppliers()
        {
            using (var db = new SupplierDAL())
            {
                return db.tblSuppliers
                    .Where(x => x.isBlocked == true)
                    .ToList();
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

        public tblSupplier GetSupplierById(int id)
        {
            using (var db = new SupplierDAL())
            {
                return db.tblSuppliers.FirstOrDefault(p => p.supplierId == id);
            }
        }

        public tblSupplier GetSupplierByName(string name)
        {
            using (var db = new SupplierDAL())
            {
                return db.tblSuppliers
                    .Where(p => p.name == name)
                    .FirstOrDefault();
            }
        }

        public int AddSupplier(tblSupplier supplier)
        {
            if (supplier != null)
            {
                using (var db = new SupplierDAL())
                {
                    db.tblSuppliers.Add(supplier);
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
                tblSupplier provider = GetSupplierById(id);
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
