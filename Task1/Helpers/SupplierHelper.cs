using System;
using System.Collections.Generic;
using DTO;
using BussinessLogic;

namespace Task1.Helpers
{
    public class SupplierHelper
    {
        public EntityBL providerBL = new EntityBL();

        public void Manage()
        {
            Console.Clear();
            Console.WriteLine("List of suppliers - 1; \tNew supplier - 2; \tBlocked suppliers - 3; Menu - 4;");
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
                    Program.Menu();
                    break;
                default:
                    break;
            }
        }
        
        public void GetBlockedSuppliers()
        {
            ShowSuppliers(providerBL.GetBlockedSuppliers());
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
            var suppliers = providerBL.GetSuppliers();
            ShowSuppliers(suppliers);

            Console.WriteLine("Search - 1; \t Sort  - 2; \t Block provider - 3; \tDelete provider - 4; \t Supplier details - 5; \nGo Back - 0; ");
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
                case 5:
                    GetSupplierDetails();
                    break;
                case 0:
                    Manage();
                    break;
                default:
                    break;
            }
        }

        private void GetSupplierDetails()
        {
            Console.WriteLine(" Enter id of suppplier ");
            Int32.TryParse(Console.ReadLine(), out int id);
            var s = providerBL.GetSupplierById(id);
            List<ProductDTO> products = providerBL.GetProductsBySupplierID(id);
            ShowSupplierDetails(s, products);

            ProductCRUD(id, s);
        }

        private static void ShowSupplierDetails(SupplierDTO s, List<ProductDTO> products)
        {
            Console.Clear();
            Console.WriteLine("\t\tSupplier`s details:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            ShowSuppliers(s);
            Console.ResetColor();
            Console.WriteLine("\tProducts:");
            ProductHelper.ShowProducts(products);
        }

        private void ProductCRUD(int id, SupplierDTO s)
        {
            Console.WriteLine("Add product - 1 ; Delete product - 2; Back - 0;");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    AddProduct(s);
                    ShowSupplierDetails(s, providerBL.GetProductsBySupplierID(id));
                    ProductCRUD(id, s);
                    break;
                case 2:
                    DeleteProduct(s.supplierId);
                    ShowSupplierDetails(s, providerBL.GetProductsBySupplierID(id));
                    ProductCRUD(id,s);
                    break;
                default:
                    Console.Clear();
                    GetSuppliers();
                    break;
            }
        }

        private void DeleteProduct(int sup_id)
        {
            Console.Write("Enter id : " );

            Int32.TryParse(Console.ReadLine(), out int id);

            providerBL.DeleteProduct(id,sup_id);
        }

        private void AddProduct(SupplierDTO s)
        {
            ProductHelper.ShowProducts(providerBL.GetProducts());
            Console.Write("Enter product id ");

            Int32.TryParse(Console.ReadLine(), out int id);

            var prod = providerBL.GetProductById(id);
            if (s == null || prod == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No product with id: {id}!!!");
                Console.ResetColor();
                return;
            }
            providerBL.AddSupplierProduct(s, prod);
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
                        ShowSuppliers(providerBL.GetSupplierByName(supName));
                        break;
                    case 2:
                        Console.Write("Enter name of supplier: ");
                        Int32.TryParse(Console.ReadLine(), out int id);
                        ShowSuppliers(providerBL.GetSupplierById(id));
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
                        ShowSuppliers(providerBL.SortSuppliers(providerBL.GetSuppliers(), 1));
                        break;
                    case 2:
                        ShowSuppliers(providerBL.SortSuppliers(providerBL.GetSuppliers(), 2));
                        break;
                    case 3:
                        ShowSuppliers(providerBL.SortSuppliers(providerBL.GetSuppliers(), 3));
                        break;
                    case 4:
                        ShowSuppliers(providerBL.SortSuppliers(providerBL.GetSuppliers(), 4));
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
            providerBL.BlockById(id);
            GetSuppliers();
        }

        public void UnblockSupplier()
        {
            Console.Write("Enter Provider Id :");
            Int32.TryParse(Console.ReadLine(), out int id);
            providerBL.UnblockById(id);
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
            if (isOrganization.Key == ConsoleKey.Y)
            {
                newSupplier.isOrganization = true;
            }
            else
            {
                newSupplier.isOrganization = false;
            }

            Console.Write("\nRating(0-10): ");
            Int32.TryParse(Console.ReadLine(), out int rating);
            if (rating <= 10 && rating >= 0)
            {
                newSupplier.rating = rating;
            }
            else { newSupplier.rating = 0; }
            

            providerBL.AddSupplier(newSupplier);
            Console.WriteLine($"{newSupplier.name } added");
            Manage();
        }

        public void DeleteSupplierById()
        {
            Console.Write("Enter Provider Id :");
            Int32.TryParse(Console.ReadLine(), out int id);

            providerBL.DeleteSuppliersById(id);
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

        
