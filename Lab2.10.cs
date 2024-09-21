/* Write a class named ‘Shape’ having Length and Breadth properties
   along with default and parametrized constructor. The parametrized 
   constructor should accept two inputs and initialize the properties
   of the class. Create new class rectangle from shape class and
   calculate area of rectangle. */

/* using System;
namespace LAB
{
    class Shape
    {
        public double length = 0.0;
        public double width = 0.0;
        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(double length, double width) : base(length, width)
        {
        }
        public void Area()
        {
            double area = 0.0;
            area = length * width;
            Console.WriteLine("Area of Rectangle is :{0:0.00} ", area);
        }
    }
    internal class Constructor
    {
        static void Main(string[] args)
        {
            double length, width = 0.0;
            Console.WriteLine("Enter the Length");
            length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width");
            width = Double.Parse(Console.ReadLine());
            Rectangle objRectangle = new Rectangle(length, width);
            objRectangle.Area();
            Console.ReadLine();
        }
    }
}*/