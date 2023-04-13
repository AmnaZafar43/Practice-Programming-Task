using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using a1.BL;

namespace a1
{ 
    class Program
    {       
        static void Main(string[] args)
        {
            int num = 0,num1 = 0;
            shape s = new cirle();
            s.getType();
            num = s.getArea();
            num1 = s.number();
            Console.WriteLine("Number is " + num + " and new number is " + num1);
            Console.ReadKey();
        }
    }
}
