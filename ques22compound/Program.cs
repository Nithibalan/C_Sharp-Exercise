using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques22compound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal balance:");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of times interest:");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of times period :");
            float t = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest :");
            float r = float.Parse(Console.ReadLine());

            double nt = (n * t);
            double ci = (1 + r / n);
            double c = Math.Pow(ci, nt);
            double compound = (p * c);
            Console.WriteLine("Compound interest:"+compound);





        }
    }
}
