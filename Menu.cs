using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Menu
    {
        public static void listMainMenu()
        {
            Console.Clear();
            System.Console.WriteLine("Choose action you want perform: ");
            System.Console.WriteLine("1 - List user accounts");
            System.Console.WriteLine("2 - List blocked accounts");
            System.Console.WriteLine("3 - Payment or withdraw");
            System.Console.WriteLine("4 - Create account statistics");

            int option = 0;

            while (option != 1 || option != 2 || option != 3)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Account lists:");
                        Actions.listUsers();
                        break;
                    case 2:
                        Console.WriteLine("Blocked accounts:");
                        Actions.listBlockedAccounts();
                        break;
                    case 3:
                        Console.WriteLine("Payment or withdraw:");
                        break;
                    case 4:
                        Console.WriteLine("User statistics: ");
                        Actions.listUsersStatistics();
                        break;
                    default:
                        Console.WriteLine("Wrong option please select correct option!");
                        option = Int32.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
