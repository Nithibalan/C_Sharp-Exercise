using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques20basicpay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the basic salary:");
            float bs = float.Parse(Console.ReadLine());
             double da =(bs * 0.25);
            Console.WriteLine("Dearness Allowance:"+da);
             double Ta = (bs * 0.05);
             Console.WriteLine("Travel Allowing:" + Ta);
             double pf = ((bs +da)*0.08);    ;
             Console.WriteLine("Enter the Provident Fund:" +pf);
             double grosspay = (bs + da + Ta - pf);
             Console.WriteLine("The grosspay of Basic Salary is:"+grosspay);
            




            
        }
    }
}
