using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extendFunctionality.BL
{
    internal class student
    {
        protected string name;
        protected string session;
        protected int subjects;
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSession(string session)
        {
            this.session = session;
        }
        public void setSubjects(int subjects)
        {
            this.subjects = subjects;
        }
        public int getFee()
        {
            //Fee 4000 per subject
            int fee;
            fee = subjects * 4000;
            return fee;
        }
    }
}
