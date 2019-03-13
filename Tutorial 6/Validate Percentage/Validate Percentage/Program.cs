using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validate_Percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Passed = false;
            int Percentage = 0;
            
            do
            {
                    Console.WriteLine("Please enter a percentage between 0 and 100 - (Without %)");
                    Percentage = Convert.ToInt32(Console.ReadLine());
                    if (Percentage > 100 || Percentage < 0)
                    {
                           Console.WriteLine("\nInvaild input");
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                    }
                    else
                    {
                        Passed = true;
                    }

                     
            }while (Passed == false);

            Console.WriteLine("\nYou entered {0}%", Percentage);
            Console.ReadKey();
        }
    }
}
