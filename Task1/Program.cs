using System;
using System.Threading;
using Task1.BL;
using Task1.Helpers;
using TradeCompany.Database;
using TradeCompanyDAL;
namespace Task1
{
    public class Program
    {
        public static bool isLogged;
        public static SupplierHelper provider = new SupplierHelper();
        public static void Main(string[] args)
        {
            Menu();
            //isLogged = LoginHelper.Login();
            //if (isLogged)
            //{
            //   Menu();
            //}

            Console.WriteLine("Press anything to stop program. GL!");
            Console.ReadKey();
        }
        
        public static void Menu()
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
                    provider.Manage();
                    break;
                case 0:
                    Console.Clear();
                    isLogged = LoginHelper.Login();
                    break;
                default:
                    break;
            }
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
            user.AddUser(new tblUser { fullName = "Rudy Mancuso", email = "gmail.com", isFemale = true, phoneNumber = "+24947187" });
        }
        
    }
}
