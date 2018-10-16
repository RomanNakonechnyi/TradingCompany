using DTO;
using System;
using System.Threading;
using Task1.BL;
using Task1.Helpers;
using TradeCompany.Database;
using TradeCompanyDAL;
using System.Security.Cryptography;
using System.Text;

namespace Task1
{
    public class Program
    {
        public static bool isLogged;
        public static SupplierHelper provider = new SupplierHelper();
        public static UserDTO admin;
        public static void Main(string[] args)
        {
            //Menu();
            admin = LoginHelper.Login();
            isLogged = admin != null;
            if (isLogged)
            {
               Menu();
            }

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
                    isLogged = false;
                    break;
                default:
                    break;
            }
        }

        private static void ProfilePage()
        {
            Console.Clear();
            Console.WriteLine($"Full Name :{admin.fullName} \n email : {admin.eMail} \n Phone Number : {admin.phoneNumber}");
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
            user.AddUser(new UserDTO { fullName = "Rudy Mancuso",
                eMail = "gmail.com",
                isFemale = true,
                phoneNumber = "+24947187",
                login = "admin",
                passHash = EncryptionHelper.Encrypt("1234"),
                isSupplierManager = true });
        }
        
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(uTF8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
    }
}
