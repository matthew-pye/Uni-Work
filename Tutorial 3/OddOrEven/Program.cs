using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            LabelMain:

            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            int number = 0;

            try
            {
                number = Convert.ToInt32(input);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThis was not a number ... Wait 3 Seconds");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto LabelMain;
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", number);
            }

            else
            {
                Console.WriteLine("{0} is an odd number", number);
            }

            Console.ReadKey();
        }
    }
}
