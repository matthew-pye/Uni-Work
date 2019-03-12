using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rate_CSharp
{
    class Program
    {
        static int[] Votes = new int[11];
        static string[] VoteName = new String[11] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
        static int input = -2;

        static void Main(string[] args)
        {
            Input();
            Output();
        }

        static void Input()
        {
            do
            {          
                Console.WriteLine("Please rate C# on a scale of 0 to 10");
            
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invaild Input");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Input();
                }

                if (input == -1)
                {
                    break;
                }

                if (input > 10 || input < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invaild Input");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Input();
                }

                Votes[input]++;
                Console.Clear();

            } while (input != -1);

            Output();
        }

        static void Output()
        {
            Array.Sort(Votes, VoteName, 0, 11);
            int average = 0;

            if (Votes[10] == 0)
            {
                Console.WriteLine("\n#########################################");
                Console.WriteLine("Rank \t| Rating \t| # of Votes \t#");
                Console.WriteLine("----------------------------------------#");
                Console.WriteLine("No votes were entered \t\t\t#");

            }
            else
            {
                int inputted = 10;
                int Rank = 1;
                Console.WriteLine("\n#########################################");
                Console.WriteLine("Rank \t| Rating \t| # of Votes \t#");
                Console.WriteLine("--------|---------------|---------------#");

                do
                {
                    Console.WriteLine("{0}# \t| {1} \t\t| {2} \t\t#", Rank, VoteName[inputted], Votes[inputted]);
                    inputted--;
                    Rank++;

                    average += Votes[inputted];

                } while (inputted != 0);
            }

            average /= 10;
            Console.WriteLine("----------------------------------------#");
            Console.WriteLine("The average is {0} \t\t\t#", average);
            Console.WriteLine("#########################################");
            Console.ReadLine();
        }
    }
}