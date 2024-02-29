using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth: ");
            string length = Console.ReadLine();
            string breadth = Console.ReadLine();
            double len = Convert.ToDouble(length);
            double bre = Convert.ToDouble(breadth);
            double area = len * bre;
            Console.WriteLine($"Area = {area}");
            Console.ReadKey();
        }
    }
}
