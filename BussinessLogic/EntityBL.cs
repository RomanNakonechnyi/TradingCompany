using BussinessLogic.Interfaces;
using DAL;
using DTO;
using System.Collections.Generic;

namespace BussinessLogic
{
    public class EntityBL : IEntityBL
    {
        private UserDAL _userDAL;
        private SupplierDAL _supplierDAL;
        private ProductDAL _productDAL;
        private SupplierProductDAL _supplierProductDAL;

        public EntityBL()
        {
            _userDAL = new UserDAL();
            _supplierDAL = new SupplierDAL();
            _productDAL = new ProductDAL();
            _supplierProductDAL = new SupplierProductDAL();
        }

        public UserDTO ValidateLogin(string login, string password)
        {
            return _userDAL.ValidateLogin(login, password);
        }

        public int AddUser(UserDTO user)
        {
            _userDAL.AddUser(user);
            return user.userID;
        }

        public Dictionary<SupplierDTO, List<ProductDTO>> GetSuppliersWithProducts()
        {
            return _supplierDAL.GetSuppliersWithProducts();
        }

        public List<SupplierDTO> SortSuppliers(List<SupplierDTO> suppliers, int type)
        {
            return _supplierDAL.SortSuppliers(suppliers, type);
        }

        public List<SupplierDTO> GetBlockedSuppliers()
        {
            return _supplierDAL.GetBlockedSuppliers();
        }

        public int UnblockById(int id)
        {
            return _supplierDAL.UnblockById(id);
        }

        public int BlockById(int id)
        {
            return _supplierDAL.BlockById(id);
        }

        public SupplierDTO GetSupplierById(int id)
        {
            return _supplierDAL.GetSupplierById(id);
        }

        public int DeleteSuppliersById(int id)
        {
            return _supplierDAL.DeleteSuppliersById(id);
        }

        public int AddSupplier(SupplierDTO supplier)
        {
            return _supplierDAL.AddSupplier(supplier);
        }

        public SupplierDTO GetSupplierByName(string name)
        {
            return _supplierDAL.GetSupplierByName(name);
        }

        public List<SupplierDTO> GetSuppliers()
        {
            return _supplierDAL.GetSuppliers();
        }
        //product dal
        public List<ProductDTO> GetProductsBySupplierID(int id)
        {
            return _productDAL.GetProductsBySupplierID(id);
        }

        public ProductDTO GetProductById(int id)
        {
            return _productDAL.GetProductById(id);
        }

        public List<ProductDTO> GetProducts()
        {
            return _productDAL.GetProducts();
        }

        public void DeleteProduct(int id, int sup_id)
        {
            _supplierProductDAL.DeleteProduct(id, sup_id);
        }

        public void AddSupplierProduct(SupplierDTO s, ProductDTO prod)
        {
            _supplierProductDAL.AddSupplierProduct(s, prod);
        }
    }
}
