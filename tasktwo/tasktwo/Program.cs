using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tasktwo
{
    class Program
    {
        static void doctor(string name,string gender,string spec,int age)
        {
            Console.Write("Enter doctor name: ");
            name = Console.ReadLine();
            Console.Write("Enter doctor gender: ");
            gender = Console.ReadLine();
            Console.Write("Enter doctor specialization: ");
            spec = Console.ReadLine();
            Console.Write("Enter Doctor age: ");
            age = int.Parse(Console.ReadLine());
            string path = "doc.txt";
            StreamWriter doc = new StreamWriter(path);
            doc.WriteLine(name+ " " +gender+ " "+spec+ " " +age);
            doc.Flush();
            doc.Close();
        }
        static void view_doctor(string name,string gender,string spec,int age)
        {
            string path = "doc.txt";
            StreamReader doc = new StreamReader(path);
            if(File.Exists(path))
            {
                string word;
                while((record=doc.ReadLine())!=null)
                {
                    word = parseData(record, 1);
                }
            }
        }
        static void Main(string[] args)
        {
            string name="", gender="", spec="";
            int age=0;
            doctor(name, gender, spec, age);
            view_doctor(name, gender, spec, age);
            Console.ReadKey();
        }
    }
}
