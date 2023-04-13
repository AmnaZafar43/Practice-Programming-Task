using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    class Program
    {
        static void addition(int num1,int num2)
        {
            int result;
            result = num1 + num2;
            Console.WriteLine("Sum is {0}", result);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter number one: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number two: ");
            num2 = int.Parse(Console.ReadLine());
            addition(num1, num2);
            Console.ReadKey();
        }
    }
}
