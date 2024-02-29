using System;
namespace quadEq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficients of the quadratic equation:");
            Console.Write("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            if (discriminant == 0)
            {
                Console.WriteLine($"Root1= {root1}");
                Console.WriteLine($"Root2= {root2}");
                Console.WriteLine("Roots are real and equal.");
            }
            else if (discriminant > 0)
            {
                Console.WriteLine($"Root1= {root1}");
                Console.WriteLine($"Root2= {root2}");
                Console.WriteLine("Roots are real and distinct.");
            }
            else
            {
                Console.WriteLine($"Root1= {root1}");
                Console.WriteLine($"Root2= {root2}");
                Console.WriteLine("Roots are imaginary.");
            }
            Console.ReadLine();
        }
    }
}

