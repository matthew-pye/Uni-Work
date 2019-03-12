using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int result = Number;

            for (int i = 1; i < Number; i++)
            {
                result *= i;
            }

            Console.WriteLine("The factorial of {0} is {1}", Number, result);
            Console.ReadLine();

        }
    }
}
