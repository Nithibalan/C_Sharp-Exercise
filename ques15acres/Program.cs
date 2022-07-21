using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques15acres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of a field:");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("width of a field:");
            double w = double.Parse(Console.ReadLine());
            double sq = (l * w);
            Console.WriteLine("Length and width of sq.ft is:" + sq);
            double ft =(sq/43560);
            Console.WriteLine("Area of a field in acres:" +ft);


        }
    }
}
