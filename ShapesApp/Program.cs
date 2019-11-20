using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine();
            // Здесь вызывается метод Draw() из класса ThreeDCircle
            ThreeDCircle threeD = new ThreeDCircle();
            threeD.Draw();

            // Здесь вызывается метод Draw() родительского класса
            ((Circle)threeD).Draw();

            Console.ReadLine();
        }
    }
}
