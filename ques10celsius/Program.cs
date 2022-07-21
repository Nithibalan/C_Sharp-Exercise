using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques10celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius to Fahrenheit");
            Console.WriteLine("Enter the Celsius:");
            float celsius = float.Parse(Console.ReadLine());
            double Fahrenheit = ((celsius*9/5)+32);
            Console.WriteLine("Celsius to Fahrenheit:"+Fahrenheit);
        }
    }
}
