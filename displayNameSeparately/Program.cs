using System;
namespace displayNameSeparately
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();
            int firstSpaceIndex = fullName.IndexOf(' ');
            int lastSpaceIndex = fullName.LastIndexOf(' ');
            Console.WriteLine($"First Name: {fullName.Substring(0, firstSpaceIndex)}");
            if (lastSpaceIndex > firstSpaceIndex)
            {
                Console.WriteLine($"Middle Name: {fullName.Substring(firstSpaceIndex + 1, lastSpaceIndex - firstSpaceIndex - 1)}");
                Console.WriteLine($"Last Name: {fullName.Substring(lastSpaceIndex + 1)}");
            }
            else
            {
                Console.WriteLine("Last Name: (not provided)");
            }

            Console.ReadLine();
        }
    }
}

