using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Article
    {
        public Person? Person { get; private set; }
        public string? Name { get; private set; }
        public double Rate { get; private set; }

        public Article(Person person, string name, double rate) 
        {
            if(person is null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }

            Person = person;
            Name = name;
            Rate = rate;
        }

        public Article()
        {
            Person = new Person();
            Name = "Unknown";
            Rate = 0.0;
        }

        public string ToFullString() =>
            string.Join(", ", Person?.ToFullString(), Name, Rate);
    }
    public enum Frequency
    {
        Weekly, Monthly, Yearly
    }

    
}
