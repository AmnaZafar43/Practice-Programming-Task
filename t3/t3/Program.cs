using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t3.BL;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, id;
            string name;
            Console.WriteLine("Enter person age...");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter person id...");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter person name...");
            name = Console.ReadLine();
            person obj = new person(age, name, id);
            Console.ReadKey();
        }
    }
}
