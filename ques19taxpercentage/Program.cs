using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques19taxpercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total amount:");
            long amount = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax percentage:");
            float tax = long.Parse(Console.ReadLine());
            double netamount = (amount / (1 + tax / 100));
            Console.WriteLine("The netamount is:"+netamount);

        }
    }
}
