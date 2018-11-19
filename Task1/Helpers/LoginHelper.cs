using DTO;
using System;
using System.Threading;
using DAL;
using BussinessLogic;

namespace Task1.Helpers
{
    static class LoginHelper
    {
        public static EntityBL entityBL = new EntityBL();
        public static UserDTO Login()
        {
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine("Login to continue !!!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warning! You have {0} attempts and after you will be blocked.", 3 - counter);
                Console.ResetColor();
                Console.Write("Login : ");
                var login = Console.ReadLine().Trim();

                Console.Write("Pa$$word : ");
                var password = EncryptionHelper.Encrypt(ReadPassword().Trim());

                var validated = entityBL.ValidateLogin( login, password );

                if ( validated == null )
                {
                    counter++;
                }
                else if ( validated!= null )
                {
                    Console.WriteLine("\t\t\t WELCOME ");
                    return validated;
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\tCONGRATSxD!!! YOU HAVE BEEN BLOCKED!!!");
            Console.ResetColor();
            return null;
        }

        public static UserDTO ValidateLogin(string login, string password)
        {
            var approved = entityBL.ValidateLogin(login, password);
            if ( approved == null )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect login or password");
                Console.ResetColor();
                return null;
            }
            return approved;
        }

        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length - 1);
                        int pos = Console.CursorLeft;
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                    
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }
}
