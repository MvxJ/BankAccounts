using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public  class BankAccounts
    {
        private string _accountNumber;

        private int _userId;

        private string _currency;

        private double _balance;

        private Boolean _isBlocked;

        public BankAccounts(string accountNumber, int userId, string currency, double balance, Boolean isBlocked)
        {
            _accountNumber = accountNumber;
            _userId = userId;
            _currency = currency;
            _balance = balance;
            _isBlocked = isBlocked;
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public Boolean IsBlocked
        {
            get { return _isBlocked;}
            set { _isBlocked = value;}
        }
    }
}
