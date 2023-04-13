using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extendFunctionality.BL;

namespace extendFunctionality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hostellite std = new hostellite();
            std.setSubjects(4);
            int fee = std.getFee();
            Console.WriteLine("Fee " + fee);
            Console.ReadKey();
        }
    }
}
