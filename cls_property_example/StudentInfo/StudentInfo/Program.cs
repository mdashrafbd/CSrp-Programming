using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{

    class Student
    {
        private int std_id = 100;
        private string f_name = "f";
        private string l_name = "l";
        private int contact = 017;
        private string dept_name = "dept";

        public int Std_id
        {

            get {
                return std_id;
            }

            set {
                std_id = value;
            }
        }

        public string F_name {

            get {
                return f_name;
            }

            set {
                f_name = value;
            }


        }

        public string L_name
        {

            get
            {
                return l_name;
            }

            set
            {
                l_name = value;
            }

        }


        public int Contact
        {

            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string Dept_name
        {

            get
            {
                return dept_name;
            }

            set
            {
                dept_name = value;
            }


        }

        public override string ToString()
        {
            return "ID = " + std_id + ", First Name = " + f_name + ", Last Name = " + l_name + ", ContactNo = " + contact + ", Department = " + dept_name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Std_id = 101;
            std.F_name = "Sakib Al";
            std.L_name = "Hasan";
            std.Contact = 01926022512;
            std.Dept_name = "CSE";
            Console.WriteLine("Info: {0}", std);

            std.Std_id = 102;
            std.F_name = "Tamim";
            std.L_name = "Iqbal";
            std.Contact = 01926022513;
            std.Dept_name = "EEE";
            Console.WriteLine("Info: {0}", std);

            std.Std_id = 103;
            std.F_name = "Mushfiqur";
            std.L_name = "Rahim";
            std.Contact = 01926022514;
            std.Dept_name = "ELL";
            Console.WriteLine("Info: {0}", std);

            Console.ReadLine();
        }
    }
}
