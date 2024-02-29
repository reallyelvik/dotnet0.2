

namespace multipleInheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class A
{
    public void Display()
    {
        Console.Write("AAAA");
    }
}

class B
{
    public void Display()
    {
        Console.Write("BBBB");
    }
}

class C : A, B
{
    public void ShowDisplay()
    {
        Console.Write("Hello");
    }
}
