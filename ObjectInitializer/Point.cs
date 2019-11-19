using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    enum PointColor
    {
        LightBlue, BloodRed, Gold
    }
    partial class Point
    {
        public Point(PointColor color)
        {
            Color = color;
        }
        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }
    }
}
