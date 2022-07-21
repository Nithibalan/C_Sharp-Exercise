using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques5numerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numerator number:");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator number:");
            int denominator = Convert.ToInt32(Console.ReadLine());

            double quotient=(numerator/denominator);
            double reminder=(numerator%denominator);

            Console.WriteLine("The value of quotient is:"+quotient);
            Console.WriteLine("The value of reminder is:" +reminder);

        }
    }
}
