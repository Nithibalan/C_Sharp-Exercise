using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques18waiter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the bill amount:");
            int bill = int.Parse(Console.ReadLine());
            double waiter = (bill * 5 / 100);
            Console.WriteLine("Tip to be provided to the waiter:"+waiter);
        }
    }
}
