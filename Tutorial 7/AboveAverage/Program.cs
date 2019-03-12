using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboveAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are being processed?");
            int ProcessedNum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (ProcessedNum > 0)
            {
                String[] StudentName = new string[ProcessedNum];
                int[] StudentGrade = new int[ProcessedNum];

                int Inputted = 0;

                do
                {
                    Console.WriteLine("Input student data:");
                    Console.WriteLine("Name: ");
                    StudentName[Inputted] = Console.ReadLine();

                    Console.WriteLine("Grade: ");
                    StudentGrade[Inputted] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Added!");
                    System.Threading.Thread.Sleep(1000);
                    Inputted++;
                    Console.Clear();
                } while (Inputted != ProcessedNum);

                Inputted = 0;
                int Total = 0;

                do
                {
                    Total += StudentGrade[Inputted];
                    Inputted++;

                } while (Inputted != ProcessedNum);

                int average = Total / ProcessedNum;
                Inputted = 0;

                Console.WriteLine("Average = {0}", average);
                Console.WriteLine("The student that have achived above average: ");

                do
                {
                    if (StudentGrade[Inputted] > average)
                    {
                        Console.WriteLine(StudentName[Inputted] + ", " + StudentGrade[Inputted]);
                    }

                    Inputted++;

                } while (Inputted != ProcessedNum);

            }
            else
            {
                Console.WriteLine("No Student to input");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
