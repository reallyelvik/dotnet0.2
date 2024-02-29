namespace palindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt16(Console.ReadLine());
        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is not a palindrome.");
        }
        Console.ReadLine();
    }

    static bool IsPalindrome(int num)
    {
        int originalNumber = num;
        int reversedNumber = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNumber = reversedNumber * 10 + digit;
            num /= 10;
        }

        return originalNumber == reversedNumber;
    }
}
