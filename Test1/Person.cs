using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Person
    {
        private string _firstname;
        private string _lastname;
        private DateOnly _date;

        public string Firstname
        {
            get => _firstname; 
        }

        public string Lastname
        {
            get => _lastname; 
        }
        public DateOnly Date
        {
            get => _date; 
        }

        public int Year
        {
            get { return _date.Year; }

            set { _date = new DateOnly(value, _date.Month, _date.Day); }
        }

        public Person(string firstname, string lastname, DateOnly date)
        {
            if(string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException(nameof(firstname));
            }

            if (string.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentException(nameof(lastname));
            }

            _firstname = firstname;
            _lastname = lastname;
            _date = date;
        }

        public Person()
        {
            _firstname = "Unknown";
            _lastname = "Unknown";
            _date = new DateOnly(1970, 01, 01);
        }

        public string ToFullString() =>
            string.Join(", ", _firstname + " " + _lastname, _date);

        public string ToShortString() =>
            string.Join(", ", _firstname + " " + _lastname);
    }
}
