namespace studentClassRoom;

class Program
{
    static void Main(string[] args)
    {
        Student std = new Student();
        Console.Write("Enter your name: ");
        int id = Convert.ToInt16(Console.ReadLine());
        string name = Console.ReadLine();
        std.SetData(id, name);
        std.DisplayData();
        Console.ReadKey();
    }
}
class Student
{
    private int id;
    private string name;
    public void SetData(int id, string name)
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
