using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Reader
    {
        public static List<Users> getUsers()
        {
            List<Users> users = new List<Users>();

            File.ReadAllLines("D:\\Users\\maksymilian.jachymcz\\source\\repos\\BankAccounts\\osoby.csv").Skip(1).ToList().ForEach(csvUser => {
                users.Add(createUser(csvUser));
            });

            return users;
        }

        public static List<BankAccounts> getBankAccounts()
        {
            List<BankAccounts> bankAccounts = new List<BankAccounts>();

            File.ReadAllLines("D:\\Users\\maksymilian.jachymcz\\source\\repos\\BankAccounts\\konta.csv").Skip(1).ToList().ForEach(csvAccount => {
                bankAccounts.Add(createAccount(csvAccount));
            });

            return bankAccounts;
        }

        private static Users createUser(string csvUser)
        {
            string[] values = csvUser.Split(";");
            Users user = new Users(
                Convert.ToInt32(values[0]),
                values[1],
                values[2],
                values[3],
                values[4]
            );

            return user;
        }

        private static BankAccounts createAccount(string csvAccount)
        {
            string[] values = csvAccount.Split(";");
            Boolean blocked = false;

            if (values[4] == "TAK")
            {
                blocked = true;
            }

            BankAccounts account = new BankAccounts(
                values[0],
                Int32.Parse(values[1]),
                values[2],
                Convert.ToDouble(values[3]),
                blocked
            );

            return account;
        }
    }
}
