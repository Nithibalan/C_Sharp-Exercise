using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques6square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            double number = double.Parse(Console.ReadLine());
            double value = Math.Pow(number, 2);
            Console.WriteLine("The square of given value is:"+value);
        }
    }
}
