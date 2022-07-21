using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques17average
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number:");
            long first = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            long second = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            long third = long.Parse(Console.ReadLine());
            double numbers = (first + second + third);
            Console.WriteLine("The Total is:"+numbers);
            double average = (numbers / 3);
            Console.WriteLine("The Average of Three numbers is:"+average);
        }
    }
}
