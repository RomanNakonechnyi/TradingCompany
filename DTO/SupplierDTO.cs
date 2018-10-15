using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompany.Database;

namespace DTO
{
    public class SupplierDTO
    {
        public int supplierId { get; set; }
        public string name { get; set; }
        public int rating { get; set; }
        public bool? isOrganization { get; set; }
        public bool isBlocked { get; set; }
        public virtual ICollection<tblSupplierProduct> tblSupplierProducts { get; set; }
    }
}
