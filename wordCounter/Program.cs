using System;
namespace wordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int vowelCount = 0;
            int consonantCount = 0;
            int digitCount = 0;
            int spaceCount = 0;
            int wordCount = 0;
            int otherCount = 0;

            foreach (char character in sentence)
            {
                if (char.IsLetter(character))
                {
                    if ("aeiouAEIOU".Contains(character))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
                else if (char.IsDigit(character))
                {
                    digitCount++;
                }
                else if (char.IsWhiteSpace(character))
                {
                    spaceCount++;
                }
                else
                {
                    otherCount++;
                }
            }
            wordCount = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine($"Vowels: {vowelCount}");
            Console.WriteLine($"Consonants: {consonantCount}");
            Console.WriteLine($"Digits: {digitCount}");
            Console.WriteLine($"Spaces: {spaceCount}");
            Console.WriteLine($"Words: {wordCount}");
            Console.WriteLine($"Other Characters: {otherCount}");

            Console.ReadLine();
        }
    }
}

