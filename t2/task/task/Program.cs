using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using task.BL;

namespace task
{
    class Program
    {
        static void main_menu()
        {
            Console.WriteLine("\n\t");
            Console.WriteLine("**********************");
            Console.WriteLine("*     MAIN MENU      *");
            Console.WriteLine("**********************");
            Console.WriteLine("\n");
            Console.WriteLine("1- Add Students");
            Console.WriteLine("2- View Students");
            Console.WriteLine("3- Top Three Students");
            Console.WriteLine("\n");
            
        }
        static int input_option()
        {
            int option;
            Console.WriteLine("Enter your option... ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static student add_student()
        {
            student a = new student();
            Console.WriteLine("Enter student name... ");
            a.name = Console.ReadLine();
            Console.WriteLine("Enter student roll no... ");
            a.roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student gpa... ");
            a.gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter student department... ");
            a.department = Console.ReadLine();
            add_infile(a);
            return a;
        }
        static void add_infile(student a)
        {
            string path = "data.txt";
            StreamWriter data = new StreamWriter(path,true);
            data.WriteLine(a.name + "," + a.roll + "," + a.gpa + "," + a.department);
            data.Flush();
            data.Close();
        }
        static void load_fromfile(List<student> b)
        {
            string path = "data.txt";           
            StreamReader data = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = data.ReadLine())!=null)
                {
                    student s = new student();
                    s.name = parseData(record, 1);
                    s.roll = int.Parse(parseData(record, 2));
                    s.gpa = float.Parse(parseData(record, 3));
                    s.department = parseData(record, 4);
                    b.Add(s);

                }
                data.Close();
            }
            else
            {
                Console.WriteLine("File not exist...");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
        static string parseData(string record,int field)
        {
            int comma = 1;
            string item = "";
            for(int i=0;i<record.Length;i++)
            {
                if(record[i] == ',')
                {
                    comma = comma + 1;
                }
                else if(comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void view_students(List<student> b)
        {
            for(int i=0;i<b.Count;i++)
            {
                Console.Write(b[i].name + "  " + b[i].roll + "  " + b[i].gpa + "  " + b[i].department);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int op = 0; ;
            List<student> stu = new List<student>();
            Console.Clear();
            main_menu();
            op = input_option();
            while (op < 4)
            {             
                if(op == 1)
                {
                    stu.Add(add_student());
                }
                if(op == 2)
                {
                    load_fromfile(stu);
                    view_students(stu);
                }
                if(op == 3)
                {

                }
            }
            Console.ReadKey();

        }
    }
}
