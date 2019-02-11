using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedViolation
{
    public class Rectangle 
    {
        public double Width { get; set; }
        public double Height { get; set; }

    }

    public class Circle
    {
        public double Radius { get; set; }
    }

    public class Square 
    {
        public double Side { get; set; }
  
    }

    public class AreaCalculator
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var item in shapes)
            {
                if (item is Rectangle)
                {
                    var rectangle = ((Rectangle)item);
                    area = rectangle.Width *rectangle.Height;
                }
                if (item is Square)
                {
                    var square  = ((Square)item);
                    area = square.Side *square.Side;
                }
                if (item is Circle)
                {
                    var circle = ((Circle)item);
                    area = Math.Exp(circle.Radius)*Math.PI;
                }

            }

            return area;
        }
    }
}
