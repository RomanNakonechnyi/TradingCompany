using AutoMapper;
using DAL.Interfaces;
using DTO;
using System.Linq;
using TradeCompany.Database;

namespace DAL
{
    public class UserDAL : TradeCompanyEntities, IUserDAL
    {
        readonly IMapper _mapper;
        public UserDAL()
        {
            var config = new MapperConfiguration(c => c.AddProfiles(typeof(UserDAL)));
            _mapper = config.CreateMapper();
        }
        public int AddUser(UserDTO user)
        {
            UserDAL db = new UserDAL();
            
                user = _mapper.Map < UserDTO > (db.tblUsers.Add(_mapper.Map<tblUser>(user)));
                db.SaveChanges();
           
            return user.userID;
        }

        public UserDTO ValidateLogin(string login, string password)
        {
            using (var db = new UserDAL())
            {
                var user = db.tblUsers.Where(s => s.login == login).FirstOrDefault(s=>s.isSupplierManager==true);
                if (user!= null && user.passHash == password)
                {
                    return _mapper.Map<UserDTO>(user);
                }
                    return null;
            }
        }
    }
}
