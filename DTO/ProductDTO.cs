using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompany.Database;

namespace DTO
{
    public class ProductDTO
    {
        public int productId { get; set; }
        public string name { get; set; }
        public int? producerId { get; set; }
        public decimal price { get; set; }
        public int? categoryId { get; set; }
        public string details { get; set; }
        public virtual tblCategory tblCategory { get; set; }
        public virtual tblProducer tblProducer { get; set; }
    }
}
