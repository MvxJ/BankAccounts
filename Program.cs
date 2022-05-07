using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BankAccounts
{
    class Program
    {
        public static List<Users> users = Reader.getUsers();
        public static List<BankAccounts> bankAccounts = Reader.getBankAccounts();

        static void Main(string[] args)
        {
            Menu.listMainMenu();
        }
    }
}