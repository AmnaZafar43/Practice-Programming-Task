using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amna
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int largest = -1;
            Console.WriteLine("Enter three numbers:");
            for(int i = 0;i < 3;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                if(arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.Write("Largest value is {0}", largest);
            Console.ReadKey();
        }
    }
}
