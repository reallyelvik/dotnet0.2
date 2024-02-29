namespace structure;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your name: ");
        int id = Convert.ToInt16(Console.ReadLine());
        string name = Console.ReadLine();
        Student std = new Student(id, name);
        std.DisplayData();
        Console.ReadKey();
    }
}
struct Student
{
    private int id;
    private string name;
    public Student(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public void DisplayData()
    {
        Console.WriteLine("Id: " + id);
        Console.WriteLine("Name: " + name);
    }
}
