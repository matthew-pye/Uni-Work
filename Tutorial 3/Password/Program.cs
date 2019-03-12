using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "youwillneverguess";
            int tries = 3;
            labelStart:

            Console.WriteLine("Please enter the password");
            string input = Console.ReadLine();

            if (input == password)
            {
                Console.WriteLine("\nThat was the correct password");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Well Done!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                if (tries == 0)
                {
                    System.Environment.Exit(1);
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThat is the incorrect password");
                    tries -= 1;
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Tries Remaining - {0}", tries);
                    goto labelStart;
                }
            }

            Console.ReadKey();
        }
    }
}
