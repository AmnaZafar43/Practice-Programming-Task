using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1.BL;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec=0,min=0,hr=0;
            clockType t = new clockType();
            clockType t1 = new clockType();
            clockType time = new clockType();
            clockType time1 = new clockType(8);
            clockType time2 = new clockType(8,10);
            clockType time3 = new clockType(8,10,10);
            Console.WriteLine("Empty time "+time.hour + "  " + time.mint + "  " + time.second);
            Console.WriteLine("Hour time " + time1.hour + "  " + time1.mint + "  " + time1.second);
            Console.WriteLine("Full time " + time3.hour + "  " + time3.mint + "  " + time3.second);
            hr = t.increment_hours(8);
            Console.WriteLine("Increment hour is " + hr + "  " + time3.mint + "  " + time3.second);
            min = time2.increment_mint(10);
            Console.WriteLine("Increment mint is " + hr + "  " + min + "  " + time3.second);
            sec = t1.increment_second(10);
            Console.WriteLine("Increment second is " + hr + "  " + min + "  " + sec);
            Console.ReadKey();
        }
    }
}
