using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompany.Database;

namespace TradeCompanyDAL
{
    public class UserDAL:TradeCompanyEntities
    {
        public int AddUser(tblUser user)
        {
            using (UserDAL db = new UserDAL())
            {
                db.tblUsers.Add(user);
                db.SaveChanges();
            }
            return 1;
        }

        public bool ValidateLogin(string login, string password)
        {
            using (var db = new UserDAL())
            {
                var user = db.tblUsers.FirstOrDefault(s => s.login == login);
                if (user!= null)
                {
                    return user.passHash == password;
                }
                    return false;
            }
        }
    }
}
