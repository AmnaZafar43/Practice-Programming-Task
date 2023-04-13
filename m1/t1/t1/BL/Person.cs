using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class Person
    {
        protected string firstName;
        protected string lastName;
        protected int personAge;

        // By default getter setters
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int PersonAge { get => personAge; set => personAge = value; }


        // Parameterized Constructor

        public Person(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName, string lastName, int personAge)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.personAge = personAge;
            Console.WriteLine(firstName + lastName + " " + personAge);
           
        }
    }
}
