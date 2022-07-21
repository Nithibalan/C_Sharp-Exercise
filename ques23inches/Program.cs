using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques23inches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the person in cm:");
            float height= float.Parse(Console.ReadLine());
           

            double ft = (height/30.48);
            Console.WriteLine("The height of the person in feet:" + ft);

            double inch = (height / 2.54);
            Console.WriteLine("The height of the person in inch:" + inch);



        }
    }
}
