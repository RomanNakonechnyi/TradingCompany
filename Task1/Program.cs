using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1.Helpers;
using TradeCompanyDAL;
namespace Task1
{
    public class Program
    {
        public static bool isLogged;
        static void Main(string[] args)
        {
            Menu();
            //isLogged = LoginHelper.Login();
            //if (isLogged)
            //{
            //    Menu();
            //}

            Console.WriteLine("Press anything to stop program. GL!");
            Console.ReadKey();
        }
        
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Profile - 1 \tManage - 2 \nLog out - 0");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    ProfilePage();
                    break;
                case 2:
                    Manage();
                    break;
                case 0:
                    isLogged = false;
                    return;
                default:
                    break;
            }
        }

        private static void Manage()
        {
            Console.Clear();
            Console.WriteLine("List of suppliers - 1 \tNew supplier - 2");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    GetSuppliers();
                    break;
                case 2:
                    AddNewSupplier();
                    break;
                case 0:
                    isLogged = false;
                    return;
                default:
                    break;
            }
        }

        private static void AddNewSupplier()
        {
            throw new NotImplementedException();
        }

        private static void GetSuppliers()
        {
            ProviderDAL provider = new ProviderDAL();

            var providers = provider.GetProviders();
            Console.WriteLine("{0,-5} {1,-13} {2,-10} {3,-7}",
                "ID",
                "Name",
                "IsOrganiz",
                "Rating");
            foreach (var p in providers)
            {
                Console.WriteLine( "{0,-5} {1,-13} {2,-10} {3,-7}", 
                    p.providerID, 
                    p.name, 
                    p.isOrganization, 
                    p.rating);
            }

            Console.WriteLine("Search - 1 \t Sort  - 2 \t Go Back - 0 ");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    SearchSuppliers();
                    break;
                case 2:
                    SortSuppliers();
                    break;
                case 0:
                    isLogged = false;
                    return;
                default:
                    break;
            }
        }

        private static void SearchSuppliers()
        {
            Console.Write("Enter name of supplier: ");
            var supName = Console.ReadLine();
        }

        private static void SortSuppliers()
        {
            Console.WriteLine("Choose way of sorting : by name descending - 1" +
                "\tby name ascending - 2");
            do
            {
                Console.Write("make you choice ");
                Int32.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        Console.WriteLine("sorted by desc");
                        break;
                    case 2:
                        Console.WriteLine("sorted by asc");
                        break;
                    case 0:
                        GetSuppliers();
                        break;
                    default:
                        break;
                }

            } while (true);
        }

        private static void ProfilePage()
        {
            Console.Clear();
            Console.WriteLine("Here will be administrator info ");
            Console.WriteLine("Back - 1 \tChange Profile - 2");
            Int32.TryParse(Console.ReadLine(), out int key);
            switch (key)
            {
                case 1:
                    Menu();
                    break;
                case 2:
                    UpdateProfile();
                    break;
                default:
                    break;
            }
        }

        private static void UpdateProfile()
        {
            Console.Clear();
            Console.WriteLine("This feature will be implemented in next version");
            Thread.Sleep(2000);
            ProfilePage();
        }

        public static void AddUser()
        {
            UserDAL user = new UserDAL();
            user.AddUser(new tblUser { fullName = "Rudy Mancuso", eMail = "gmail.com", isFemale = true, phoneNumber = "+24947187" });
        }
        
    }
}
