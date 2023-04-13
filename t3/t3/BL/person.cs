using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3.BL
{
    class person
    {
        private int age;
        private string name;
        private int id;

        public person(int age,string name,int id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }
        public int getage()
        {
            return age;
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int Age)
        {
            age = Age;
        }
        public void setId(int Id)
        {
            id = Id;
        }
        public void setName(string Name)
        {
            name = Name;
        }
            

    }
}
