using DTO;
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
    }
}
