using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.BL
{
    internal class hostellite:student
    {
        private int RoomNumber;
        private bool isFridgeAvailable;
        private bool isInternetAvailable;

        public hostellite(string name):base(name)
        {
            Console.WriteLine(name);
        }

        public int RoomNumber1 { get => RoomNumber; set => RoomNumber = value; }
        public bool IsFridgeAvailable { get => isFridgeAvailable; set => isFridgeAvailable = value; }
        public bool IsInternetAvailable { get => isInternetAvailable; set => isInternetAvailable = value; }

        public int getHostelFee()
        {
            int fee = 0;
            // Code to calculate fee
            return fee;
        }
    }
}
