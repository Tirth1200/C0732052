using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732052
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1008; i > 117; i -= 81)
                sum += i;
            Console.WriteLine("The sum of the the Nummber is :" + sum);
            Console.ReadLine();
        }
    }
}
