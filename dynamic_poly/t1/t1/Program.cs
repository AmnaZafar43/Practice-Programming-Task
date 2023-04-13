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
            double width, height, radius;
            int side;
            Console.WriteLine("Enter width");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side");
            side = int.Parse(Console.ReadLine());
            rectangle obj = new rectangle(width,height);
            Console.WriteLine("The shape is " + obj.getShape() + " and area is " + obj.getArea());
            circle obj1 = new circle(radius);
            Console.WriteLine("The shape is " + obj1.getShape() + " and area is " + obj1.getArea());
            Console.ReadKey();
        }
    }
}
