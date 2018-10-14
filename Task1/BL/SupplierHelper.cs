using System;
using System.Collections.Generic;
using DTO;
using DAL;

namespace Task1.BL
{
    public class SupplierHelper
    {
        public SupplierDAL supplier = new SupplierDAL();

        public void Manage()
        {
            Console.Clear();
            Console.WriteLine("List of suppliers - 1; \tNew supplier - 2; \tBlocked suppliers - 3; \n 4 - Suppliers with products they deliver");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    GetSuppliers();
                    break;
                case 2:
                    AddNewSupplier();
                    break;
                case 3:
                    GetBlockedSuppliers();
                    break;
                case 4:
                    GetSuppliersWithProducts();
                    break;
                default:
                    break;
            }
        }

        private void GetSuppliersWithProducts()
        {
            Console.WriteLine("\t\t Page where all relationship between suppliers and products are listed ");
            var suppliers = supplier.GetSuppliersWithProducts();
            ShowSuppliers(suppliers);

            Console.WriteLine("Add new relationship - 1; \t Back - 0;");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    AddNewRelationship();
                    break;
                case 0:
                    Manage();
                    break;
                default:
                    break;
            }
        }

        private void AddNewRelationship()
        {
            Console.WriteLine("Update existing - 1; Create new - 2 \t Back - 0;");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    UpdateRelationShip();
                    break;
                case 2:
                    CreateRelationship();
                    break;
                case 0:
                    GetSuppliersWithProducts();
                    break;
                default:
                    break;
            }
        }

        private void CreateRelationship()
        {
            Console.WriteLine(" Choose supplier :");
            ShowSuppliers(supplier.GetSuppliers());
            Console.Write("Enter id : ");
            Int32.TryParse(Console.ReadLine(), out int key);
            var s = supplier.GetSupplierById(key);

            Console.WriteLine(" Choose supplier :");
            ProductHelper.ShowProducts(ProductHelper.provider.GetProducts());
            Console.Write("Enter id : ");
            Int32.TryParse(Console.ReadLine(), out int p_key);
            var p = ProductHelper.provider.GetProductById(p_key);

            if(s!=null && p!=null)
            {
                SupplierProductDAL.AddRelationship(s, p);
            }
            else
            {
                Console.WriteLine("Something goes wrong . Try again!");
                CreateRelationship();
            }
            GetSuppliersWithProducts();
        }

        private void UpdateRelationShip()
        {
            throw new NotImplementedException();
        }

        public void GetBlockedSuppliers()
        {
            ShowSuppliers(supplier.GetBlockedSuppliers());
            Console.WriteLine("Unblock supplier - 1; \t Back - 0;");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    UnblockSupplier();
                    break;
                case 0:
                    Manage();
                    break;
                default:
                    break;
            }
        }

        public void GetSuppliers()
        {
            var suppliers = supplier.GetSuppliers();
            ShowSuppliers(suppliers);

            Console.WriteLine("Search - 1; \t Sort  - 2; \t Block provider - 3; \tDelete provider - 4; \nGo Back - 0; ");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    SearchSuppliers();
                    break;
                case 2:
                    SortSuppliers();
                    break;
                case 3:
                    BlockSupplier();
                    break;
                case 4:
                    DeleteSupplierById();
                    break;
                case 0:
                    Manage();
                    break;
                default:
                    break;
            }
        }

        public void SearchSuppliers()
        {
            bool cont = true;
            Console.WriteLine("Choose way of searching :\n by name  - 1;\tby id - 2;");
            do
            {
                Console.Write("\nmake you choice : ");
                Int32.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        Console.Write("Enter name of supplier: ");
                        var supName = Console.ReadLine();
                        ShowSuppliers(supplier.GetSupplierByName(supName));
                        break;
                    case 2:
                        Console.Write("Enter name of supplier: ");
                        Int32.TryParse(Console.ReadLine(), out int id);
                        ShowSuppliers(supplier.GetSupplierById(id));
                        break;
                    default:
                        cont = false;
                        break;
                }
            } while (cont);
            GetSuppliers();
        }

        public void SortSuppliers()
        {
            bool cont = true;
            Console.WriteLine("Choose way of sorting :\n by name ascending - 1;" +
                " by name descending - 2; \n by rating ascending - 3; by rating descending - 4; ");
            do
            {
                Console.Write("make you choice : ");
                Int32.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        ShowSuppliers(supplier.SortSuppliers(supplier.GetSuppliers(), 1));
                        break;
                    case 2:
                        ShowSuppliers(supplier.SortSuppliers(supplier.GetSuppliers(), 2));
                        break;
                    case 3:
                        ShowSuppliers(supplier.SortSuppliers(supplier.GetSuppliers(), 3));
                        break;
                    case 4:
                        ShowSuppliers(supplier.SortSuppliers(supplier.GetSuppliers(), 4));
                        break;
                    default:
                        cont = false;

                        break;
                }
            } while (cont);
            GetSuppliers();
        }

        public void BlockSupplier()
        {
            Console.Write("Enter Provider Id :");
            Int32.TryParse(Console.ReadLine(), out int id);
            supplier.BlockById(id);
            GetSuppliers();
        }

        public void UnblockSupplier()
        {
            Console.Write("Enter Provider Id :");
            Int32.TryParse(Console.ReadLine(), out int id);
            supplier.UnblockById(id);
            GetBlockedSuppliers();
            
        }

        public void AddNewSupplier()
        {
            var newSupplier = new SupplierDTO();
            newSupplier.isBlocked = false;

            Console.Write("Name: ");
            newSupplier.name = Console.ReadLine();

            Console.Write("Whether supplier is organization (Y/N): ");
            var isOrganization = Console.ReadKey();
            if(isOrganization.Key == ConsoleKey.Y)
            {
                newSupplier.isOrganization = true;
            }
            else {
                newSupplier.isOrganization = false;
            }

            Console.Write("\nRating(0-10): ");
            Int32.TryParse(Console.ReadLine(), out int rating);
            if(rating<=10 && rating>=0)
            {
                newSupplier.rating = rating;
            }
            else { newSupplier.rating = 0; }

            supplier.AddSupplier(newSupplier);
            Manage();
        }

        public void DeleteSupplierById()
        {
            Console.Write("Enter Provider Id :");
            Int32.TryParse(Console.ReadLine(), out int id);
            
            supplier.DeleteSuppliersById(id);
            GetSuppliers();
        }

        #region display methods
        private static void ShowSuppliers(List<SupplierDTO> list)
        {
            Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                "ID",
                "Name",
                "IsOrganiz",
                "Rating");
            foreach (var s in list)
            {
                Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                    s.supplierId,
                    s.name,
                    s.isOrganization,
                    s.rating);
            }
        }
        private static void ShowSuppliers(SupplierDTO supplier)
        {
        Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                "ID",
                "Name",
                "IsOrganiz",
                "Rating");
           
        Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                supplier.supplierId,
                supplier.name,
                supplier.isOrganization,
                supplier.rating);
        }

        private static void ShowSuppliers(Dictionary<SupplierDTO, List<ProductDTO>> dict)
        {
            foreach (var s in dict)
            {
                Console.WriteLine($" \nSupplier :'{s.Key.name}'");
                ProductHelper.ShowProducts(s.Value);
            }
        }
        #endregion
    }
}

        
