using System;
namespace evencount3x3matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            int evenCount = 0;
            Console.WriteLine("Enter a 3x3 matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter element at position [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (matrix[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
            }

            Console.WriteLine($"The number of even numbers in the matrix is: {evenCount}");
            Console.ReadKey();
        }
    }
}

