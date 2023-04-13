using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class circle:shape
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public circle(double radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            double area;
            area = 2 * Math.PI * radius * radius;
            return area;
        }

        /*public override string getShape()
        {
            return "circle";
        }*/
    }
}
