using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызвать на уровне объекта
            BitmapImage bitmap = new BitmapImage();
            bitmap.Draw();
            bitmap.DrawInBoundingBox(10, 10, 100, 150);
            bitmap.DrawUpsideDown();

            // Получить IAdvancedDraw явным образом
            IAdvancedDraw advancedDraw = bitmap as IAdvancedDraw;
            if (advancedDraw != null)
                advancedDraw.DrawUpsideDown();

            Console.ReadLine();
        }
    }
}
