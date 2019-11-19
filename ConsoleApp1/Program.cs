using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Hexagon();
            shapes[1] = new Circle();
            shapes[2] = new Hexagon();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            
            Console.ReadLine();
        }
    }
}
