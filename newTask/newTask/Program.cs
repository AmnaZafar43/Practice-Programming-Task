using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum = 0;
            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Sum is {0}",sum);
            Console.ReadKey();

        }
    }
}
