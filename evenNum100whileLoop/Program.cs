using System;
namespace evenNum100whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //whileLoop
            int num = 2;
            while (num <= 100)
            {
                Console.Write(num + "\t");
                num = num + 2;
            }

            //doWhileLoop (odd)
            int num1 = 1;
            do
            {
                Console.Write(num1 + "\t");
                num1 = num1 + 2;
            } while (num1 <= 100);

            Console.ReadKey();
        }
    }
}

