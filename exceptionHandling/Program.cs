using System;
using Internal;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter two numbers: ");
                int a = Convert.ToInt16(Console.ReadLine());
                int b = Convert.ToInt16(Console.ReadLine());
                int c = a / b;
                if (b == 0)
                {
                    throw new CustomDivideByZeroException("Divide by zero exception occured");
                }
                Console.WriteLine("Result is: " + c);
                Console.Readkey();
            }
            catch (FormatException f)
            {
                Console.WriteLine("Some error occured " + f.Message);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Some error occured " + d.Message);
            }
            catch (Exception e)  //Exception Handler
            {
                Console.WriteLine("Some error occured " + e.Message);
            }
            catch (CustomDivideByZeroException ce)
            {
                Console.WriteLine("Some error occured " + ce.Message);
            }
            Console.ReadKey();
        }
    }
    class CustomDivideByZeroException : Exception
    {
        public CustomDivideByZeroException(string m) : base(m)
        {

        }
    }
}