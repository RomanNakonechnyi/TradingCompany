using System.Collections.Generic;
using DTO;

namespace BussinessLogic.Interfaces
{
    public interface IEntityBL
    {
        int AddSupplier(SupplierDTO supplier);
        void AddSupplierProduct(SupplierDTO s, ProductDTO prod);
        int AddUser(UserDTO user);
        int BlockById(int id);
        void DeleteProduct(int id, int sup_id);
        int DeleteSuppliersById(int id);
        List<SupplierDTO> GetBlockedSuppliers();
        ProductDTO GetProductById(int id);
        List<ProductDTO> GetProducts();
        List<ProductDTO> GetProductsBySupplierID(int id);
        SupplierDTO GetSupplierById(int id);
        SupplierDTO GetSupplierByName(string name);
        List<SupplierDTO> GetSuppliers();
        Dictionary<SupplierDTO, List<ProductDTO>> GetSuppliersWithProducts();
        List<SupplierDTO> SortSuppliers(List<SupplierDTO> suppliers, int type);
        int UnblockById(int id);
        UserDTO ValidateLogin(string login, string password);
    }
}