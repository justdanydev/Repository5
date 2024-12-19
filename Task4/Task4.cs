using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{

    public interface IShape
    {
        double GetPerimeter();
        double GetArea();
    }

    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double GetPerimeter()
        {
            return 4 * Side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Square square = new Square(5);

            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}, Площадь треугольника: {triangle.GetArea()}");
            Console.WriteLine($"Периметр квадрата: {square.GetPerimeter()}, Площадь квадрата: {square.GetArea()}");
        }
    }
}
