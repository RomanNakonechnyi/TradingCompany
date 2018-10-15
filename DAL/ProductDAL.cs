using AutoMapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompany.Database;
using TradeCompanyDAL;

namespace DAL
{
    public class ProductDAL : TradeCompanyEntities
    {
        readonly IMapper _mapper;
        public ProductDAL()
        {
        var config = new MapperConfiguration(c => c.AddProfiles(typeof(ProductDAL)));
        _mapper = config.CreateMapper();
        }

        public List<ProductDTO> GetProducts()
        {
            using (var db = new ProductDAL())
            {
                var prods = db.tblProducts.ToList();
                return _mapper.Map<List<ProductDTO>>(prods);
            }
        }

        public ProductDTO GetProductById(int id)
        {
            using (var db = new ProductDAL())
            {
                var product = db.tblProducts.FirstOrDefault(p => p.productId == id);
                return _mapper.Map<ProductDTO>(product);
            }
        }

        public List<ProductDTO> GetProductsBySupplierID(int id)
        {
            using (var db = new SupplierDAL())
            {
                var prods = db.tblSupplierProducts.Where(p => p.supplierID == id);

                List<ProductDTO> prodList = new List<ProductDTO>();
                foreach (var item in prods)
                {
                    prodList.Add(_mapper.Map<ProductDTO>(item.tblProduct));
                }

                return prodList;
            }
        }
    }
}
