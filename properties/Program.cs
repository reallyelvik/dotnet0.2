namespace properties;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your name: ");
        int id = Convert.ToInt16(Console.ReadLine());
        string name = Console.ReadLine();
        Student std = new Student();
        std.id = id;
        std.name = name;
        Console.WriteLine("Id= " + std.id);
        Console.WriteLine("Name= " + std.name);
        Console.ReadKey();
    }
}
class Student
{
    public int id { get; set; }
    public string name { get; set; }
}
