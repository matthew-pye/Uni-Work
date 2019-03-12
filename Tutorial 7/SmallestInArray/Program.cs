using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SmallestInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int InputNum = 0;

            do
            {
                Console.WriteLine("Please input an interger");
                Numbers[InputNum] = Convert.ToInt32(Console.ReadLine());
                InputNum++;
                Console.Clear();
            } while (InputNum != 10);

            Array.Sort(Numbers);
            InputNum = 0;

            Console.WriteLine("The numbers that you have input sorted:");

            do
            {
                Console.WriteLine(Numbers[InputNum]);
                InputNum++;

            } while (InputNum !=10);

            Console.ReadKey();
        }
    }
}
