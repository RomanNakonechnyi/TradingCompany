using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Helpers
{
    static class LoginHelper
    {
        public static bool Login()
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
                var password = ReadPassword().Trim();

                var validated = ValidateLogin(login, password);

                if (!validated)
                {
                    counter++;
                }
                else if (validated)
                {
                    Console.WriteLine("\t\t\t WELCOME ");
                    return true;
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\tCONGRATS!!! YOU HAVE BEEN BLOCKED!!!");
            Console.ResetColor();
            return false;

        }

        public static bool ValidateLogin(string login, string password)
        {
            var correctLogin = "admin";
            var correctPassword = "admin";

            if (login != correctLogin && password != correctPassword)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect login and password");
                Console.ResetColor();
                return false;
            }
            if (login != correctLogin)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect login");
                Console.ResetColor();
                return false;
            }
            if (password != correctPassword)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect password");
                Console.ResetColor();
                return false;
            }
            return true;
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
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }
    }
}
