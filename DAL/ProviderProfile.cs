using AutoMapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompany.Database;

namespace TradeCompanyDAL
{
    public class ProviderProfile : Profile
    {
        public ProviderProfile()
        {
            CreateMap<tblUser, UserDTO>();
        }
    }
}
