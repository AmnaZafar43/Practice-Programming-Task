using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class shape
    {
        protected string type;

        public string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public virtual double getArea()
        {
            return 0.0;
        }

        public virtual string getShape()
        {
            return "undefined";
        }
    }
}
