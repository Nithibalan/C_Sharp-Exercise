using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques24bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height:");
            float hg = float.Parse(Console.ReadLine());
            double height =(hg / 39.37);
            Console.WriteLine("Height in meters:"+height);

            Console.WriteLine("Enter the weight:");
            float wg = float.Parse(Console.ReadLine());
            float weight = (float)(wg * 1000);
            Console.WriteLine("Weight in kilograms:"+weight);
            double bmi = ((weight/height)*height);
            Console.WriteLine("BMI :"+bmi);



        }
    }
}
