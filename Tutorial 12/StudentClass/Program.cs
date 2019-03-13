using System;

namespace StudentClass
{
    class Program
    {
        static StudentDetails a;
        static StudentDetails b;

        static void Main(string[] args)
        {
            a = new StudentDetails("ag123456");
            b = new StudentDetails("wc223344", "Winston", "30 Nov 1874","w.c@bt.com", "018118055");

            a.ToString();
            Console.WriteLine();
            b.ToString();
            Console.ReadLine();
        }
    }
}
