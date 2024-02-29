﻿using System;
namespace menuBasedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            int choice = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    else
                        Console.WriteLine("Error! Division by zero is not allowed.");
                    break;
                case 5:
                    Console.WriteLine("Exited");
                    return;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                    break;
            }
            Console.ReadKey();
            Main(null);
        }
    }
}

