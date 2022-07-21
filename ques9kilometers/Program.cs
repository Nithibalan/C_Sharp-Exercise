using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques9kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert kilometers to miles");
            Console.WriteLine("Enter the kilometers:");
            float kilo = float.Parse(Console.ReadLine());
            double miles=(kilo/1.609);
            Console.WriteLine("Kilometers to miles:" + kilo + " kilometers" + "= " +miles + "miles");   

        }
    }
}
