using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompanyDAL;

namespace Task1.BL
{
    public static class LoginBL
    {
        public static UserDTO ValidateLogin(string login, string password)
        {
            var userDAL = new UserDAL();
            var approved = userDAL.ValidateLogin(login, password);
            if (approved == null)
            {
                return null;
            }
            return approved;
        }
    }
}
