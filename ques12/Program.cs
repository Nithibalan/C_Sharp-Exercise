using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operand1:");
            int operand1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operand2:");
            int operand2 = int.Parse(Console.ReadLine());

            int temp = operand1;
            operand1 = operand2;
            operand2 = temp;
            

            Console.WriteLine("After swapping the variables " +"operand1 is "+operand1+ " operand2 is "+operand2);


        }
    }
}
