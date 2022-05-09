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
            Console.WriteLine("1 - List user accounts");
            Console.WriteLine("2 - List blocked accounts");
            Console.WriteLine("3 - Payment or withdraw");
            Console.WriteLine("4 - Create account statistics");

            int option = 0;

            while (option != 1 || option != 2 || option != 3)
            {
                switch (option)
                {
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("Choose action you want perform: ");
                        option = Int32.Parse(Console.ReadLine());
                        break;
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
                        Actions.paymentOrWithdraw();
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
