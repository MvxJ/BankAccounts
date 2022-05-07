using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Actions
    {
        public static void listUsers()
        {
            int back = 1;

            Console.Clear();
            Console.WriteLine("Account list: ");

            var users = Program.users;
            var accounts = Program.bankAccounts;

            users.ForEach(u => writeAccounts(u, accounts));

            int userId = 0;
            Console.WriteLine();
            Console.WriteLine("Please insert user id: ");
            userId = Int32.Parse(Console.ReadLine());

            accounts.Where(a => a.UserId == userId).ToList().ForEach(account => {
                Console.WriteLine("Accoount no: " + account.AccountNumber + " | " + account.Currency + " | " + account.Balance + " | " + account.IsBlocked);
            });

            while (back != 0)
            {
                Console.WriteLine("If you want go back please insert: '0'");
                back = Int32.Parse(Console.ReadLine()); 
            }

            Menu.listMainMenu();
        }

        public static void listUsersStatistics()
        {
            int back = 1;
            var users = Program.users;
            var accounts = Program.bankAccounts;

            users.ForEach(u => {
                Console.WriteLine("User: " + u.Name + " " + u.Surname + " | " + u.Address + " | " + u.Pesel);
                Console.WriteLine("-------------------------");
                accounts.Where(a => a.UserId == u.Id).ToList().ForEach(a => {
                    Console.WriteLine("Account no: " + a.AccountNumber + " | Balance = " + a.Balance);
                });
                Console.WriteLine();
            });

            while (back != 0)
            {
                Console.WriteLine("If you want go back please insert: '0'");
                back = Int32.Parse(Console.ReadLine());
            }

            Menu.listMainMenu();
        }

        public static void listBlockedAccounts ()
        {
            int back = 1;
            var accounts = Program.bankAccounts;

            accounts.Where(a => a.IsBlocked == true).ToList().ForEach(a => {
                Console.WriteLine("Account no: " + a.AccountNumber);
            });

            while (back != 0)
            {
                Console.WriteLine("If you want go back please insert: '0'");
                back = Int32.Parse(Console.ReadLine());
            }

            Menu.listMainMenu();
        }

        public static void paymentOrWithdraw()
        {

        }

        private static void writeAccounts(Users user, List<BankAccounts> accounts)
        {
            Console.WriteLine(
                user.Id + " | " + user.Name + " " + user.Surname + " | " + user.Address + " | " + user.Pesel
            );
            Console.WriteLine();
        }
    }
}
