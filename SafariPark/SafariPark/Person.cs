using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public int age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            this.age = age;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
               
    }
}
