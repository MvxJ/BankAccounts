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
            Console.Clear();
            Console.WriteLine("User statistics: ");
            Console.WriteLine();

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

        public static void listBlockedAccounts()
        {
            Console.Clear();
            Console.WriteLine("Blocked accounts: ");

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
            Console.WriteLine("Please insert account number! or insert 'q' to go back!");

            int back = 1;
            string accountNo = Console.ReadLine();
            var accounts = Program.bankAccounts.Where(b => b.AccountNumber == accountNo);

            if (accounts.Count() > 0)
            {
                BankAccounts account = accounts.First();

                if (account.IsBlocked == true)
                {
                    Console.WriteLine("This account is blocked!");
                    paymentOrWithdraw();
                }
                else
                {
                    Console.Clear();
                    withdrawOrDeposit(account);
                }
            } else {
                if (accountNo == "q")
                {
                    Menu.listMainMenu();
                }

                Console.WriteLine("There is no account with given id!");
                paymentOrWithdraw();
            }

            while (back != 0)
            {
                Console.WriteLine("If you want go back please insert: '0'");
                back = Int32.Parse(Console.ReadLine());
            }

            Menu.listMainMenu();
        }

        private static void writeAccounts(Users user, List<BankAccounts> accounts)
        {
            Console.WriteLine(
                user.Id + " | " + user.Name + " " + user.Surname + " | " + user.Address + " | " + user.Pesel
            );
            Console.WriteLine();
        }

        private static void withdrawOrDeposit(BankAccounts account)
        {
            Console.WriteLine("Select operation: ");
            Console.WriteLine("1 - Withdrawal from the account");
            Console.WriteLine("2 - Deposit cache on the account");

            int option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please insert value to withdraw: ");
                    double withdrawValue = Double.Parse(Console.ReadLine());
                    account.Balance = account.Balance - withdrawValue;
                    updateBankAccount(account);
                    break;
                case 2:
                    Console.WriteLine("Please insert value you want to deposit: ");
                    double depositValue = Double.Parse(Console.ReadLine());
                    account.Balance = account.Balance + depositValue;
                    updateBankAccount(account);
                    break;
                default:
                    Console.WriteLine("Wrong option please try again!");
                    break;
            }
        }

        private static void updateBankAccount(BankAccounts account)
        {
            Program.bankAccounts.Where(b => b.AccountNumber == account.AccountNumber).ToList().ForEach(b =>
            {
                b = account;
            });
        }
    }
}
