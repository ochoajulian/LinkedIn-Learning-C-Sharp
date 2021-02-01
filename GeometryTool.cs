using System;

namespace LinkedIn_Learning_C_Sharp
{
    public class GeometryTool
    {
        /*static void Main(string[] args)
        {
            var square = new Square() { Width = 2 };
            var triangle = new Triangle() { Base = 2, Height = 5 };

            square.Display();
            triangle.Display();
        }*/
    }

    abstract class Shape
    { 
        public abstract int GetArea();
        public void Display()
        {
            Console.WriteLine("The area is: " + GetArea());
        }
    }

    class Square : Shape
    {
        public int Width;
        public override int GetArea()
        {
            return Width * Width;
        }
    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;

        public override int GetArea()
        {
            return ((Base * Height) / 2);
        }
    }
}