using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public int userID { get; set; }
        public string fullName { get; set; }
        public bool? isFemale { get; set; }
        public string eMail { get; set; }
        public string phoneNumber { get; set; }
        public string login { get; set; }
        public string passHash { get; set; }
        public bool? isSupplierManager { get; set; }
    }
}
