using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_MVVM
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static List<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person { FirstName = "Harry", LastName = "Potter" },
                new Person { FirstName = "Ron", LastName = "Weasley" },
                new Person { FirstName = "Hermione", LastName = "Granger" }
            };
        }
    }
}
