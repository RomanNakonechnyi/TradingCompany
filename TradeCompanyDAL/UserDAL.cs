using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCompanyDAL
{
    public class UserDAL:DbContext
    {
        public UserDAL():base("TradingCompanyEntities")
        {

        }
        public DbSet<tblUser> Users { get; set; }

        public int AddUser(tblUser user)
        {
            using (UserDAL db = new UserDAL())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            return 1;
        }
    }
}
