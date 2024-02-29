using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure f;
            Triangle t = new Triangle(5, 6);
            f = t;
            double res = f.Area();
            Console.WriteLine("Area of Triangle : " + res);
            Rectange r = new Rectange(5, 6);
            f = r;
            res = f.Area();
            Console.WriteLine("Area of Rectangle : " + res);
            Console.ReadKey();
        }
    }
    abstract class Figure
    {
        protected double dim1, dim2;
        public Figure(double dim1, double dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }
        public abstract double Area();
    }
    class Rectange : Figure
    {
        public Rectange(double dim1, double dim2) : base(dim1, dim2) //This will immediately invoke base class constructor
        {
        }
        public override double Area()
        {
            return (dim1 * dim2);
        }
    }
    class Triangle : Figure
    {
        public Triangle(int dim1, int dim2) : base(dim1, dim2)
        {
        }
        public override double Area()
        {
            return (1.0 / 2 * dim1 * dim2);
        }
    }
}