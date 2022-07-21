using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques7squareroot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            double number = double.Parse(Console.ReadLine());

            double value = Math.Sqrt(number);

            Console.WriteLine("The square root of given value is:"+value);
        }
    }
}
