using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_tickets
{
    class Program
    {
        static int[] AdultNoTickets = new int[2];
        static int[] ChildNoTickets = new int[2];
        static int[] ConcessionsNoTickets = new int[2];

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to theatre tickets\n");

            AdultTickets();         
            ChildTickets();           
            ConcessionsTickets();

            do
            {
                AdultNoTickets[1] = -1;
                ChildNoTickets[1] -= 10;

            } while (ChildNoTickets[1] >= 10);

            var total = (AdultNoTickets[1] * 10.50) + (ChildNoTickets[0] * 7.30) + (ConcessionsNoTickets[1] * 8.40);

            if (total >= 100)
            {
                total *= 0.9;
            }

            Console.Clear();
            Console.WriteLine(total);

            Console.ReadKey();
        }

        static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void AdultTickets()
        {
            labelAdult:
            Console.WriteLine("How many adult tickets do you want?");
            string AdultTickets = Console.ReadLine();

            try
            {
                AdultNoTickets[0] = Convert.ToInt32(AdultTickets);
                AdultNoTickets[1] = AdultNoTickets[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                System.Threading.Thread.Sleep(10000);


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild input");
                System.Threading.Thread.Sleep(2000);
                Console.SetCursorPosition(0, 5);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, 3);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, 2);
                ClearCurrentConsoleLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto labelAdult;
            }
        }

        static void ChildTickets()
        {
            Console.WriteLine();
            labelChild:
            Console.WriteLine("How many child tickets do you want?");
            string ChildTickets = Console.ReadLine();

            try
            {
                ChildNoTickets[0] = Convert.ToInt32(ChildTickets);
                ChildNoTickets[1] = ChildNoTickets[0];
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild input");
                System.Threading.Thread.Sleep(2000);
                Console.SetCursorPosition(0, 8);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, 6);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, 5);
                ClearCurrentConsoleLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto labelChild;
            }
        }

        static void ConcessionsTickets()
        {
            Console.WriteLine();
            labelConcessions:
            Console.WriteLine("How many Concessions tickets do you want?");
            string ConcessionsTickets = Console.ReadLine();

            try
            {
                ConcessionsNoTickets[0] = Convert.ToInt32(ConcessionsTickets);
                ConcessionsNoTickets[1] = ConcessionsNoTickets[0];
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild input");
                System.Threading.Thread.Sleep(2000);
                Console.SetCursorPosition(0, 11);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, 9);
                ClearCurrentConsoleLine();
                Console.SetCursorPosition(0, 8);
                ClearCurrentConsoleLine();
                Console.ForegroundColor = ConsoleColor.White;
                goto labelConcessions;
            }
        }
    }
}
