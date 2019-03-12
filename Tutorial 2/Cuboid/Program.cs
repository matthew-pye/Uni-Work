using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to cuboid calculator! \n");
            Console.WriteLine("Please input the dimenations of the cuboid-");
            Console.WriteLine("Width:");
            int Width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nLength:");
            int Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHeight:");
            int Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n \nOutput-");
            Console.WriteLine("Volume: {0}", (Width*Length*Height));
            int SurfaceArea = (2*(Length*Width))+(2*(Length*Height))+(2*(Height*Width));
            Console.WriteLine("Surface area: {0}", SurfaceArea);

            Console.ReadKey();
        }
    }
}
