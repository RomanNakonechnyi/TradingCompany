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
        public Nullable<bool> isFemale { get; set; }
        public string eMail { get; set; }
        public string phoneNumber { get; set; }
    }
}
