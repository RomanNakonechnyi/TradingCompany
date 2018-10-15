using AutoMapper;
using DAL;
using DTO;
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
        readonly IMapper _mapper;
        public UserDAL()
        {
            var config = new MapperConfiguration(c => c.AddProfiles(typeof(UserDAL)));
            _mapper = config.CreateMapper();
        }
        public int AddUser(UserDTO user)
        {
            using (UserDAL db = new UserDAL())
            {
                db.tblUsers.Add(_mapper.Map<tblUser>(user));
                db.SaveChanges();
            }
            return 1;
        }

        public UserDTO ValidateLogin(string login, string password)
        {
            using (var db = new UserDAL())
            {
                var user = db.tblUsers.Where(s => s.login == login).FirstOrDefault(s=>s.isSupplierManager==true);
                if (user!= null)
                {
                    return _mapper.Map<UserDTO>(user);
                }
                    return null;
            }
        }
    }
}
