using System.Collections.Generic;
using DTO;

namespace DAL.Interfaces
{
    public interface ISupplierDAL
    {
        int AddSupplier(SupplierDTO supplier);
        int BlockById(int id);
        int DeleteSuppliersById(int id);
        List<SupplierDTO> GetBlockedSuppliers();
        SupplierDTO GetSupplierById(int id);
        SupplierDTO GetSupplierByName(string name);
        List<SupplierDTO> GetSuppliers();
        Dictionary<SupplierDTO, List<ProductDTO>> GetSuppliersWithProducts();
        List<SupplierDTO> SortSuppliers(List<SupplierDTO> suppliers, int type);
        int UnblockById(int id);
    }
}