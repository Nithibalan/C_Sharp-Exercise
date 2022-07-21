using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques14random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int num  = r.Next(1,101);
            Console.WriteLine("Random numbers of 0 to 100 is:" +num);
        }
    }
}
