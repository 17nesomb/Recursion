using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5! means 5*4*3*2*1
            Console.WriteLine("Welcome to Factorial Factory!");
            Console.Write("Please enter a number: ");
            int n = 0;
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Please enter a number: ");
            }
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"{n}! is {factorial}");
        }
    }
}
