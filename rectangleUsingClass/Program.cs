using System;

namespace rectangleUsingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth: ");
            string length = Console.ReadLine();
            string breadth = Console.ReadLine();
            double len = Convert.ToDouble(length);
            double bre = Convert.ToDouble(breadth);
            Rectangle rec = new Rectangle();
            rec.setData(len, bre);
            double area = rec.getArea();
            Console.WriteLine("Area is: " + area);
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        private double length, breadth;
        public void setData(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double getArea()
        {
            return length * breadth;
        }
    }
}
