using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class rectangle:shape
    {
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double getArea()
        {
            double area;
            area = width * height;
            return area;
        }

        public override string getShape()
        {
            return "rectangle";
        }
    }
}
