using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            LabelMain:
            Console.WriteLine("Please enter the letter that you have been given");

            var letter = Console.ReadLine();
            switch (letter)
            {

                case "b":
                    Console.WriteLine("\nBills must be paid");
                    break;

                case "c":
                    Console.WriteLine("\nCirculars are thrown away");
                    break;

                case "p":
                    Console.WriteLine("\nPostcards are put on the wall");
                    break;

                case "l":
                    Console.WriteLine("\nPersonal letters are read and have repies written for them");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nInvaild input");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    goto LabelMain;
            }

        }
    }
}
