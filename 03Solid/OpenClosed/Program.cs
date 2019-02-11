using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //AreaCalculatorTest();
            var rect1 = new Rectangle { Height = 3, Width = 4 };
            var rect2 = new Rectangle { Height = 3, Width = 4 };
            //var circl = new Circle { Radius = 9 };
            //var squar = new Square { Side = 7 };

            var areaCalc = new OpenClosed();
            double total = areaCalc.Area(new[] { rect1, rect2 });
            Console.WriteLine(total);
            Console.ReadKey();






        //private static void AreaCalculatorTest()
        //{
        //    var rectangle1 = new Rectangle { Height = 2, Width = 4 };
        //    var rectangle2 = new Rectangle { Height = 2, Width = 4 };
        //    var rectangle3 = new Rectangle { Height = 2, Width = 4 };
        //    var rectangle4 = new Rectangle { Height = 2, Width = 4 };

            //    var areaCalculator = new AreaCalculator();
            //    double areaSum = areaCalculator.Area(new[] { rectangle1, rectangle2, rectangle3, rectangle4 });
        }
    }
}

