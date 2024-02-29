using System;
namespace evenNum100
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i + "\t");
            }
            Console.ReadKey();
        }
    }
}

