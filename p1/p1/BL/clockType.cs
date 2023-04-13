using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1.BL
{
    class clockType
    {
        public int hour;
        public int mint;
        public int second;
        public clockType()
        {
            hour = 0;
            mint = 0;
            second = 0;
        }
        public clockType(int h)
        {
            hour = h;
        }
        public clockType(int h, int m)
        {
            hour = h;
            mint = m;
        }
        public clockType(int h,int m,int s)
        {
            hour = h;
            mint = m;
            second = s;
        }
        public int increment_second(int s)
        {
            s++;
            return s;
        }
        public int increment_hours(int h)
        {
            h++;
            return h;
        }
        public int increment_mint(int m)
        {
            m++;
            return m;
        }
    }
}
