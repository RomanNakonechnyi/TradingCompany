using AutoMapper;
using DTO;
using TradeCompany.Database;

namespace DAL
{
    class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<tblUser, UserDTO>().ReverseMap();
        }
    }

}
