using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Check
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hoilday");
            labelDuration:
            Console.WriteLine("\nDuration of stay? (2, 7 or 14 nights)");
            var duration = Console.ReadLine();

            switch (duration)
            {
                case "2":
                    break;

                case "7":
                    break;

                case "14":
                    break;

                default:
                    goto labelDuration;
            }

            labelGuests:
            Console.WriteLine("\nNumber of guests?");
            try
            {
                int NoGuests = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                goto labelGuests;
            }


            

            labelBoard:
            Console.WriteLine("\nType of board? (Full, Half or Self-catering)");
            var board = Console.ReadLine().ToLower();

            switch (board)
            {
                case "full":
                    break;

                case "half":
                    break;

                case "self-catering":
                    break;

                default:
                    goto labelBoard;
            }

            Console.WriteLine("\n\nInput complete!!");
            Console.ReadLine();
        }
    }
}
