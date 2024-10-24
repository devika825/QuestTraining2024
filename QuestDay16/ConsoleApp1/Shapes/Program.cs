using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

       
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle: Radius = {Radius}";
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

       
        public override double GetArea()
        {
            return Length * Width;
        }

       
        public override double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public override string ToString()
        {
            return $"Rectangle: Length = {Length}, Width = {Width}";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

           
            shapes.Add(new Circle(3)); 
            shapes.Add(new Rectangle(4, 7)); 
            

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine($"Area: {shape.GetArea()}");
                Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
            }

          
        }
    }
}
