
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques2power
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the basenumber:");
            int basenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of exponent:");
            int exponent = Convert.ToInt32(Console.ReadLine());
            double ans = Math.Pow(basenumber, exponent);
            Console.WriteLine("Answer is:"+ans);
        }
    }
}
