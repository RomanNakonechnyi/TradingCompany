using DTO;

namespace DAL.Interfaces
{
    public interface ISupplierProductDAL
    {
        int AddRelationship(SupplierDTO s, ProductDTO p);
        void AddSupplierProduct(SupplierDTO s, ProductDTO prod);
        void DeleteProduct(int prod_id, int sup_id);
    }
}