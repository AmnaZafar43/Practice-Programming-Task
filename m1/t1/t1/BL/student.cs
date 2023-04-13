using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class student: Person
    {
        private int fees;
        private char section;
        private int studentAge;
       
        public char Section { get => section; set => section = value; }
       
        public int Fees { get => fees; set => fees = value; }
        public int StudentAge { get => studentAge; set => studentAge = value; }

        public student(string firstName,string lastName,int personAge,int fees, char section, int studentAge): base(firstName, lastName, personAge)
        {     
            this.firstName = firstName;
            this.lastName = lastName;
            this.personAge = personAge;
            this.fees = fees;
            this.section = section;
            this.studentAge = studentAge;
            Console.WriteLine(firstName + lastName + " " + personAge + " " + fees + " " + section);
            
        }
    }
}
