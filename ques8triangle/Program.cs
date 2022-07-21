using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques8triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the triangle:");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the triangle:");
            float breadth = float.Parse(Console.ReadLine());
            double Triangle = ((1.0/2.0) * (breadth * height));

            Console.WriteLine("Area of a Triangle  is:"+Triangle);





        }
    }
}
