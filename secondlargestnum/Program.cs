using System;
namespace secondlargestnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine($"Second largest number: {numbers[1]}");
        }
    }
}

