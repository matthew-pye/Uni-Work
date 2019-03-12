using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smaller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 4 numbers");
            int[] Values = new int[4];
            int inputted = 0;
            
            do
            {
                Values[inputted] = Convert.ToInt32(Console.ReadLine());
                inputted++;
            } while (inputted != 4);

            Console.WriteLine("The smallest value you inputted was {0}", Smaller(Values));
            Console.ReadLine();
        }

        static int Smaller(int[] Values)
        {
            Array.Sort(Values);

            return Values[0];
        }
    }
}
