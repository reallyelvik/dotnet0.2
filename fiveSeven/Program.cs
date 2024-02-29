using System;
namespace fiveSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            if (num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("The number is exactly divisible by 5 and 7");
            }
            else
            {
                Console.WriteLine("The number is not exactly divisible by 5 and 7.");
            }
            Console.ReadKey();
        }
    }

}

