using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques25marks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("Enter the student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the student Roll no:");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student Tam:");
            int Tam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student Eng:");
            int Eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student science:");
            int sci = int.Parse(Console.ReadLine());

            double Total = (Tam + Eng + sci);
            double Average = (Total / 3);
            Console.WriteLine("Total:"+Total);
            Console.WriteLine("Average:"+Average);




        }
    }
}
