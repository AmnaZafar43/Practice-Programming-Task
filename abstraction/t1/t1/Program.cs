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
            string s;
            double result;
            shape obj = new circle(4.5);
            s = obj.getShape();
            result = obj.getArea();
            Console.WriteLine(s + "," + result);
            Console.ReadKey();

        }
    }
}
