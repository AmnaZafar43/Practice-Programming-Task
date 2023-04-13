using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.BL
{
    internal class dayScholar: student
    {
        private string pickUpPoint;
        private int busNo;
        private int pickUpDistance;

        public dayScholar(string name):base(name)
        {

        }

        public string PickUpPoint { get => pickUpPoint; set => pickUpPoint = value; }
        public int BusNo { get => busNo; set => busNo = value; }
        public int PickUpDistance { get => pickUpDistance; set => pickUpDistance = value; }
    }
}
