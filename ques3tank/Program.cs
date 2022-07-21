using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques3tank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the volume of rectangular length:");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the volume of rectangular width:");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the volume of rectangular height:");
            float height = float.Parse(Console.ReadLine());

            double volume = (length * width * height);

            Console.WriteLine("The volume of rectangular water tank :"+volume);



        }
    }
}
