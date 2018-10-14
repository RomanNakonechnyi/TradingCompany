using AutoMapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompany.Database;

namespace DAL
{
    class ProductProfile :Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDTO, tblProduct>().ReverseMap();
        }
    }
}
