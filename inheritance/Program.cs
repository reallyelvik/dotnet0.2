namespace inheritance;

class Room
{
    protected int length, breadth;
    public int Area()
    {
        return (length * breadth);
    }
}
class Bedroom : Room
{
    private int height;
    public void SetData(int length, int breadth, int height)
    {
        this.length = length;
        this.breadth = breadth;
        this.height = height;

    }
    public int Volume()
    {
        return Area() * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bedroom b = new Bedroom();
        b.SetData(3, 4, 5);
        int area = b.Area();
        int vol = b.Volume();
        Console.WriteLine("Area= " + area);
        Console.WriteLine("Volume= " + vol);
        Console.ReadKey();
    }
}
