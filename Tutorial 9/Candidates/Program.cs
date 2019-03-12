using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Candidates = new string[5] {"Ahmed","Boo","Celine","Didi","Elaine"};
            int[] Votes = new int[5];

            int input;

            do
            {

                Console.WriteLine("Which candidate are you voting for: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input > 4)
                {
                    Console.WriteLine("Invaild input");
                }
                else if (input == -1)
                {
                    break;
                }
                else
                {
                    Votes[input]++;
                }
            } while (input != -1);

            Console.WriteLine("Vote Summary");
            Array.Sort(Votes,Candidates,0,5);
            Console.WriteLine("{0} {1}",Votes[0],Candidates[0]);
            Console.ReadLine();
        }
    }
}
