using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BMI_Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int Totalinchs = HeightInInchs();
            Console.Clear();
            int TotalPounds = WeightInPounds();
            Console.Clear();
            OutputBMI(TotalPounds,Totalinchs);
        }

        static int HeightInInchs()
        {
            Console.WriteLine("Please put how many feet you are:");
            int HeightFeet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease put how many inchs you are:");
            int HeightInchs = Convert.ToInt32(Console.ReadLine());

            if (HeightFeet > 7 || HeightFeet < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Feet input");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                HeightInInchs();
            }
            else if (HeightInchs > 11 || HeightInchs < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Inchs input");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                HeightInInchs();
            }

            return (HeightFeet * 12) + HeightInchs;
        }

        static int WeightInPounds()
        {     
            Console.WriteLine("Please put how many stones you are:");
            int WeightStone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease put how many pounds you are:");
            int WeightPounds = Convert.ToInt32(Console.ReadLine());

            if (WeightStone > 30 || WeightStone < 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Stones input");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                HeightInInchs();
            }
            else if (WeightPounds > 13 || WeightPounds < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild pounds input");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

                HeightInInchs();
            }

            return (WeightStone * 14) + WeightPounds;
        }

        static void OutputBMI(int TotalPounds, int Totalinchs)
        {          
            Console.WriteLine("Your BMI is {0}", (TotalPounds*703) / (Totalinchs * Totalinchs));
            Console.ReadLine();
        }
    }
}
