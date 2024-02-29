// File1: Program.cs

using System;
namespace partialClass
{

    class Program
    {
        static void Main(string[] args)
        {
            Student = new Student("Ram", 5);
            s.ShowDetail();
            Console.ReadKey();
        }
    }
}

// File2: Student.cs                                                                                                            

namespace partialClass
{

    partial class Student
    {
        public void ShowDetail()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll: " + roll);
        }
    }
}