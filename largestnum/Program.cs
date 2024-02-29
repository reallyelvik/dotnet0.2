using System;
namespace largestnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            int largestNum = numbers[0];
            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] > largestNum)
                {
                    largestNum = numbers[i];
                }
            }
            Console.WriteLine($"\n The largest number is: {largestNum}");
        }
    }
}

