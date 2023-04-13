using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendFunctionality.BL
{
    internal class hostellite:student
    {
        private int roomNumber;
        private bool isFridgeAvailable;
        private bool isInternetAvalable;

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public bool IsFridgeAvailable { get => isFridgeAvailable; set => isFridgeAvailable = value; }
        public bool IsInternetAvalable { get => isInternetAvalable; set => isInternetAvalable = value; }

        public new int getFee()
        {
            //Fee 4000 per subject
            int fee;
            fee = subjects * 4000;
            if (IsFridgeAvailable)
            {
                fee = fee + 1000;
            }
            return fee;
        }
    }
}
