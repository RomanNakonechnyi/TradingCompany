using AutoMapper;
using DTO;
using TradeCompany.Database;

namespace TradeCompanyDAL
{
    public class SupplierProfile : Profile
    {
        public SupplierProfile()
        {
            CreateMap<tblSupplier, SupplierDTO>().ReverseMap();
        }
    }
}
