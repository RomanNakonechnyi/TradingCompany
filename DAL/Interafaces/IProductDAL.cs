using System.Collections.Generic;
using DTO;

namespace DAL.Interfaces
{
    public interface IProductDAL
    {
        ProductDTO GetProductById(int id);
        List<ProductDTO> GetProducts();
        List<ProductDTO> GetProductsBySupplierID(int id);
    }
}