using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    public interface IMovable
    {
        void Move(int x, int y);
    }

    public class Point : IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public class Rectangle : IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Width}, {Height})";
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Point point = new Point(10, 20);
            Rectangle rect = new Rectangle(30, 40, 50, 60);

            Console.WriteLine($"Точка до перемещения: {point}");
            Console.WriteLine($"Прямоугольник до перемещения: {rect}");

            point.Move(5, 10);
            rect.Move(-2, 7);


            Console.WriteLine($"\nТочка после перемещения: {point}");
            Console.WriteLine($"Прямоугольник после перемещения: {rect}");
        }
    }
}
