using System;
namespace removeVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something: ");
            string userInput = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string result = "";
            foreach (char character in userInput)
            {
                if (!vowels.Contains(character))
                {
                    result += character;
                }
            }
            Console.WriteLine("Result string: " + result);
            Console.ReadLine();
        }
    }
}

