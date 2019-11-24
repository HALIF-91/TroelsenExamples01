using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов членов интерфейса на уровне объектов
            Hexagon hex = new Hexagon("Гексагон");

            Console.WriteLine($"Points: {hex.Points}");

            // Получение ссылок на интерфейсы: ключевое слово as
            IPointy pointy = hex as IPointy;

            if(pointy != null)
                Console.WriteLine("Points: {0}", pointy.Points);
            else
                Console.WriteLine("OOPS! Not pointy...");
            Console.WriteLine();

            // Получение ссылок на интерфейсы: ключевое слово is
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            foreach (Shape shape in myShapes)
            {
                shape.Draw();

                if(shape is IPointy)
                    Console.WriteLine("-> Points: {0}", ((IPointy)shape).Points);
                else
                    Console.WriteLine("{0}\'s not pointy!", shape.PetName);

                if (shape is IDraw3D)
                    DrawIn3D((IDraw3D)shape);

                Console.WriteLine();
            }

            IPointy pointyItem = FindPointyItem(myShapes);
            if(pointyItem != null)
                Console.WriteLine("The item has {0} points", pointyItem.Points);

            Console.ReadLine();
        }

        private static IPointy FindPointyItem(Shape[] shapes)
        {
            foreach (Shape shape in shapes)
            {
                if (shape is IPointy)
                    return shape as IPointy;
            }
            return null;
        }

        // Использование интерфейсов в качестве параметров
        private static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        // Использование интерфейсов в качестве возвращаемых значений
    }
}
