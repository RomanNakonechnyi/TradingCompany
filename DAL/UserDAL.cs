using AutoMapper;
using DTO;
using System.Linq;
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
