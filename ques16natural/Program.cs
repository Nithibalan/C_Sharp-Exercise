using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques16natural
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
           

            int natural = (num * (num + 1)/ 2);
            Console.WriteLine("natural numbers :" +(natural));
          

            




        }
    }
}
