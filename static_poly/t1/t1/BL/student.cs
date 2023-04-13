using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class student
    { 
        private string name;
        private int age;
        private int id;
        private string foreign;
        private double fees;
        
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }
        public string Foreign { get => foreign; set => foreign = value; }
        public string Name { get => name; set => name = value; }
        public double Fees { get => fees; set => fees = value; }

        public student(string name)
        {
            this.name = name;
            Console.WriteLine("1- " + name);
        }

        public student(string name,int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("1- " + name + ": age " + age);
        }
        public student(string name,string foreign)
        {
            this.name = name;
            this.foreign = foreign;
        }

        public student(string name,int age,int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            Console.WriteLine("1- " + name + ": age " + age + ": id" + id);
        }

        public student(string name, int age, int id, string foreign, double fees)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.foreign = foreign;
            this.fees = fees;
            Console.WriteLine("\n\tName is " + name + " :Age is " + age + " :Id is " + id + " :Foreigner(y/n) " + foreign + ":Fees " + fees);
        }

        public void calculateFee()
        {
            Console.WriteLine("\n\tFees of nationalist student is " + fees);
        }
        public void calculateFee(string foreign)
        {
            fees = fees + 35000;
            Console.WriteLine("\n\tFees of foreigner student is " + fees);
        }
    }
}
