using System;
namespace input10numforandforeachloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Display numbers using for loop
            Console.WriteLine("Displaying numbers using for loop:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i] + "\t");
            }
            // Display numbers using foreach loop
            Console.WriteLine("Displaying numbers using foreach loop:");
            foreach (int number in numbers)
            {
                Console.Write(number + "\t");
            }
            Console.ReadKey();
        }
    }
}

