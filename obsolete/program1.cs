using System;
using System.Diagnostics.CodeAnalysis;
using Internal;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Console.WriteLine("Sum= " + m.Sum(5, 6));
            Console.WriteLine("Product= " + m.Mul(5, 6));
        }
    }
    class Mathematics
    {
        [Log("Sum Function", Message = "This function finds the sum between two numbers")]
        public int Sum(int a, int b)
        {
            return (a + b);
        }
        [Log("Multiplication Function", Message = "This function finds the product between two numbers")]
        public int Mul(int a, int b)
        {
            return (a * b);
        }
    }
    [AttributeUsage(AttributeTargets.Method)]
    class LogAttribute : Attribute
    {
        string functionname;
        public LogAttribute(string functionname)
        {
            this.functionname = functionname;
        }
        public string Message { get; set; }
    }
}
