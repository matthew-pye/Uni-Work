using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_positive_and_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int Cycle = 0;
            
            do
            {
                Console.WriteLine("Please enter integer {0}",(Cycle+1));
                try
                {
                    numbers[Cycle] = Convert.ToInt32(Console.ReadLine());
                    Cycle++;
                    Console.Clear();
                }
                catch(Exception e)
                {
                    Console.WriteLine("\nInvaild Input!!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                              
            }while(Cycle <= 9);


            Cycle = 0;
            int posTotal = 0;
            int negTotal = 0;
            int NoOfPos = 0;
            int NoOfNeg = 0;
            do
            {

                if(numbers[Cycle] >= 0)
                {
                    posTotal += numbers[Cycle];
                    NoOfPos++;
                }
                if (numbers[Cycle] <= -1)
                {
                    negTotal += numbers[Cycle];
                    NoOfNeg++;
                }
                Cycle++;

            }while(Cycle<=9);


            Console.WriteLine("Sum of positive numbers {0} \nSum of negative numbers {1}",posTotal ,negTotal);
            if (posTotal == 0)
            {
                Console.WriteLine("\nAverage of positive numbers {0} \nAverage of negative numbers {1}", (posTotal), (negTotal / NoOfNeg));
            }
            else if (negTotal == 0)
            {
                Console.WriteLine("\nAverage of positive numbers {0} \nAverage of negative numbers {1}", (posTotal / NoOfPos), (negTotal));
            }
            else
            {
                Console.WriteLine("\nAverage of positive numbers {0} \nAverage of negative numbers {1}", (posTotal / NoOfPos), (negTotal / NoOfNeg));
            }

            
            Console.ReadKey();

        }
    }
}
