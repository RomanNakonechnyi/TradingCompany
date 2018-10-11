using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCompanyDAL
{
    public class ProviderProfile : Profile
    {
        public ProviderProfile()
        {
            CreateMap<tblUser,UserDTO>()
                .ForMember(dst => dst.)
        }
    }
}
