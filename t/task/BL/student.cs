using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.BL
{
    internal class student
    {
        protected string name;
        protected string session;
        protected bool isDayScholar;
        protected int EntryTestMarks;
        protected int HSMarks;
        public student(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        /*public void setName(string name)...
        public void setSession(string session)...
        public void setIsDayScholar(bool isDayScholar)...
        public void setEntryTestMarks(int EntryTestMarks)...
        public void setHSMarks(int HSMarks)...
        public string getName()...*/
        public double calculateMerit()
        {
            double merit = 0.0;
            // Code to calculate merit
            return merit;
        }

    }
}
