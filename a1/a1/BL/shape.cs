using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace a1.BL
{
    abstract class shape
    {
       private string type;

        public string Type { get => type; set => type = value; }

        public virtual void getType()
        {
            Console.WriteLine("Undefined");
        }
        public abstract int getArea();

        public int number()
        {
            return 10;
        }
    }
}
