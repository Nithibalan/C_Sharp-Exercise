using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicprograms1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("NAME:" + name);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("AGE:"+age);

            Console.WriteLine("Enter your salary:");
            double salary=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("SALARY:"+salary);

            Console.WriteLine("The salary is:"+salary.ToString("c"));

        }
    }
}
