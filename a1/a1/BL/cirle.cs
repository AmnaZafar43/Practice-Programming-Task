using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1.BL
{
    internal class cirle:shape
    {
        public override void getType()
        {
            Console.WriteLine("Circle");

        }

        public override int getArea()
        {
            return 56;
        }

        public int getNumber()
        {
            return 90;
        }
    }
}
