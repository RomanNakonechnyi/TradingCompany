using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCompanyDAL;
using Task1;
using System.Threading;
using TradeCompany.Database;
using DTO;

namespace Task1.BL
{
    public class SupplierHelper
    {
        public SupplierDAL supplier = new SupplierDAL();

        public void Manage()
        {
            Console.Clear();
            Console.WriteLine("List of suppliers - 1; \tNew supplier - 2; \tBlocked suppliers - 3;");
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
                default:
                    break;
            }
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

            ShowSuppliers(supplier.GetSuppliers());

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
                        ShowSupplier(supplier.GetSupplierByName(supName));
                        break;
                    case 2:
                        Console.Write("Enter name of supplier: ");
                        Int32.TryParse(Console.ReadLine(), out int id);
                        ShowSupplier(supplier.GetSupplierById(id));
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

            Console.Write("Rating(0-10): ");
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
        private static void ShowSupplier(SupplierDTO supplier)
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
        #endregion
    }
}
