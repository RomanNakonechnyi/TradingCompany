using AutoMapper;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TradeCompany.Database;

namespace DAL
{
    public class SupplierDAL : TradeCompanyEntities, ISupplierDAL
    {
        readonly IMapper _mapper;
        public SupplierDAL()
        {
            var config = new MapperConfiguration( c => c.AddProfiles(typeof(SupplierDAL)));
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

        public Dictionary<SupplierDTO,List<ProductDTO>> GetSuppliersWithProducts()
        {
            var dict = new Dictionary<SupplierDTO, List<ProductDTO>>();
            using ( var db = new SupplierDAL() )
            {
                var sups = db.tblSuppliers
                    .Where(x => x.isBlocked == false)
                    .ToList();

                foreach ( var s in sups )
                {
                    List<ProductDTO> prodList = new List<ProductDTO>();
                    if(s.tblSupplierProducts == null)
                    {
                        dict.Add(_mapper.Map<SupplierDTO>(s), null);
                    }
                    else
                    {
                        foreach (var item in s.tblSupplierProducts)
                        {
                            prodList.Add(_mapper.Map<ProductDTO>(item.tblProduct));
                        }
                        dict.Add(_mapper.Map<SupplierDTO>(s), prodList);
                    }
                }
                return dict;
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

        public void Update(SupplierDTO supplier)
        {
            using (var db = new SupplierDAL())
            {
                var old = db.tblSuppliers.FirstOrDefault(s => s.supplierId == supplier.supplierId);
                old.name = supplier.name;
                old.isOrganization = supplier.isOrganization;
                old.isBlocked = supplier.isBlocked;
                db.SaveChanges();
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

        public List<SupplierDTO> GetSupplierByName(string name)
        {
            using (var db = new SupplierDAL())
            {
                var suppliers = db.tblSuppliers
                    .Where(p => p.name == name);
                return _mapper.Map<List<SupplierDTO>>(suppliers);
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

        SupplierDTO ISupplierDAL.GetSupplierByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
