using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques4circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius:");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the pi:");
            float pi= float.Parse(Console.ReadLine());
            double circle = (2 * radius * pi);
            Console.WriteLine("perimeter of a circle is:"+circle);


        }
    }
}
