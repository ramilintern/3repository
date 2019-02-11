using System;

namespace Polimorphism
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.Exp(Radius) * Math.PI;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }
        public override double Area()
        {
            return Side * Side;
        }
    }

    public class OpenClosed
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var item in shapes)
            {
                area += item.Area();
            }

            return area;
        }
    }


}
