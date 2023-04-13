using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t1.BL;

namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreigner obj = new foreigner("Moscow", "09876543112");
            obj.Fees = 70000.0f;
            student obj1 = new student("Aymee Amad", 19, 123, "no", 70000.0D);
            obj.calculateFee();
            Console.ReadKey();
        }
    }
}
