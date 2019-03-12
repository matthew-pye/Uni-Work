using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets
{
    class Program
    {
        static void Main(string[] args)
        {

            int teachers = 1;
            int students = 14;
            int sweets = 40;

            int SweetsPerStudent = sweets / students;
            int TeacherSweets = sweets % students;

            Console.WriteLine("Number of sweets per student: {0}", SweetsPerStudent);
            Console.WriteLine("Teachers Sweets: {0}", TeacherSweets);
            Console.ReadLine();

        }
    }
}
