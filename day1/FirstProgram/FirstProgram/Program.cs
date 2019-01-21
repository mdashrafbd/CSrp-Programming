using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{

    class Rectangle
    {

        double width;
        double height;

        public void Acceptdetails()
        {
            width = 3.5;
            height = 4.5;

        }

        public double GetArea() {

            return width * height;
        }

        public void Display() {

            Console.WriteLine("width = {0}", width);
            Console.WriteLine("height = {0}", height);
            Console.WriteLine("Area = {0}", GetArea());
            Console.WriteLine("Size of int is : {0}", sizeof(int));
        }

    }

    class ArrayExample {
        int[] num = new int[10];

        public void PrintArray()
        {

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i * 100;
                Console.WriteLine("element[{0}] is {1}", i, num[i]);

            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            /*
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine(c);
            */

            Rectangle rect = new Rectangle();
            ArrayExample ae = new ArrayExample();
            rect.Acceptdetails();
            rect.Display();
            ae.PrintArray();
            Console.ReadLine();

        }

    }

    
}
