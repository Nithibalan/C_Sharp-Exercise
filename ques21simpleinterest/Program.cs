using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques21simpleinterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the TimePeriod:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest:");
            int R = int.Parse(Console.ReadLine());
            long si = (long)(p * N * R / 100);
            Console.WriteLine("Simple Interest :" +si);


        }
    }
}
