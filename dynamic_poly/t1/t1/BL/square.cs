using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class square:shape
    {
        private int side;

        public int Side { get => side; set => side = value; }

        public override double getArea()
        {
            double area;
            area = side * side;
            return area;
        }
        public override string getShape()
        {
            return "square";
        }
    }
}
