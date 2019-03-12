using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
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

            Console.WriteLine("The numbers that you have input are:");
            InputNum = 0;

            do
            {
                Console.WriteLine(Numbers[InputNum]);
                InputNum++;
            } while (InputNum != 10);

            Console.WriteLine("\nAnd in reverse:");
            InputNum = 9;

            do
            {
                Console.WriteLine(Numbers[InputNum]);
                InputNum--;
            } while (InputNum != -1);

            Console.ReadKey();
        }
    }
}
