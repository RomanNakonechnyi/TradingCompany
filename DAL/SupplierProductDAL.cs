﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompany.Database;

namespace DAL
{
    public class SupplierProductDAL : TradeCompanyEntities
    {
        public static int AddRelationship(SupplierDTO s,ProductDTO p)
        {
            using (var db = new SupplierProductDAL())
            {
                var newRelationship = new tblSupplierProduct()
                {
                    productID = p.productId,
                    supplierID = s.supplierId
                };
                db.tblSupplierProducts.Add(newRelationship);
                db.SaveChanges();
                return newRelationship.SupProdId;
            }
        }

        public static void DeleteProduct(int prod_id,int sup_id)
        {
            using (var db = new SupplierProductDAL())
            {
                var entity = db.tblSupplierProducts.Where(p => p.productID == prod_id).FirstOrDefault(p=>p.supplierID==sup_id);
                db.tblSupplierProducts.Remove(entity);
                db.SaveChanges();
            }
        }

        public static void AddProduct(SupplierDTO s, ProductDTO prod)
        {
            using (var db = new SupplierProductDAL())
            {
                var x = db.tblSupplierProducts.Where(p => p.supplierID == s.supplierId);
                var entity = x.FirstOrDefault(p => p.productID == prod.productId);
                if(entity == null)
                {
                    AddRelationship(s, prod);
                }

            }
        }
    }
}
