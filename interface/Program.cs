using Internal;
using sealedMethod;

namespace sealedMethod;

class Program
{
    static void Main(string[] args)
    {
        Display d;
        // Monitor m = new Monitor();
        // d = m;
        LED l = new LED();
        d = l;
        d.ShowDisplay();
        Console.ReadKey();
    }
}
interface Display
{
    void ShowDisplay();
}

class Monitor : Display
{
    public void ShowDisplay()
    {
        Console.WriteLine("Displaying from monitor");
    }
}

class LED : Display
{
    public void ShowDisplay()
    {
        Console.WriteLine("Displaying from LED");
    }
}