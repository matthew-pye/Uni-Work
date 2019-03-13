using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the width of the grid");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of the grid");
            int height = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int j = 0;

            do
            {
                do
                {
                    Console.Write("* ");

                    j++;
                }while(width >= j);
                j = 0;
                Console.WriteLine("");
                i++;
            }while(height>= i);

            Console.ReadKey();
        }
    }
}
