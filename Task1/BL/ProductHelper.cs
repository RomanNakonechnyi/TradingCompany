using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    public class ProductHelper
    {
        public static ProductDAL provider = new ProductDAL();
        
        public static void ShowProducts(List<ProductDTO> products)
        {
            if(products.Count == 0)
            {
                Console.WriteLine("No available products for this supplier ");
                return;
            }
            Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-12} {4,-10}",
                "ID",
                "Name",
                "Price(UAH)",
                "Category",
                "Producer"
            );
            foreach (var item in products)
            {
                Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-12} {4,-10}",
                    item.productId,
                    item.name,
                    item.price,
                    item.tblCategory.name,
                    item.tblProducer.name);
            }
        }
    }
}
