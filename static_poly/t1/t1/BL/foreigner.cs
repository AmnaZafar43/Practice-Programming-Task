using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    internal class foreigner: student
    {
        private string countryName;
        private string contactNo;

        public string CountryName { get => countryName; set => countryName = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }

        public foreigner(string countryName,string contactNo):base(countryName,contactNo)
        {
           this.countryName = countryName;
            this.contactNo = contactNo;

            Console.WriteLine("Country name is " + countryName + ": Contact no is " + contactNo);
        }
    }
}
