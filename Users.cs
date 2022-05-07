using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Users
    {
        private int _id;

        private string _name;

        private string _surname;

        private string _pesel;

        private string _address;

        public Users(int id, string name, string surname, string pesel, string address)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _pesel = pesel;
            _address = address;
        }

        public int Id { 
            get { return _id; } 
            set { _id = value; }
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Pesel {
            get { return _pesel; }
            set { _pesel = value; }
        }

        public string Address {
            get { return _address; }
            set { _address = value; }
        }
    }
}
