using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LiteraryAuthors
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Authors = new string[10] {"william shakespeare", "mark twain", "jane austin", "charlotte bronte", "lousia may alcott", "lewis carroll", "d.h. lawrence", "charles dickens", "lucy maud montgomery", "alexander dumas"};

            Console.WriteLine("Enter an authors name: ");
            string input = Console.ReadLine().ToLower();
            int inputNum = 0;

            do
            {
                if (input == Authors[inputNum])
                {
                    Console.WriteLine("The author that you have input is placed {0}", inputNum+1);
                    Console.ReadLine();
                    break;
                }

                inputNum++;
            } while (inputNum != 10);

            if (inputNum >= 10)
            {
                Console.WriteLine("The author that you have input is not in the top 10");
                Console.ReadLine();
            }



        }
    }
}
