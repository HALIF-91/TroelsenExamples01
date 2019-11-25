using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceHierarchy
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        // Использование явной реализации для устранения конфликтов имен членов
        // не допускается модификатор, методы неявно приватны, чтобы достучаться
        // необходимо создать ссылку на интерфейс, 
        // так как эти методы, там определены неявно открытыми
        /*void IDrawable.Draw()
        {
            Console.WriteLine("Idrawable drawing...");
        }
        void IPrintable.Draw()
        {
            Console.WriteLine("Iprintable drawing...");
        }*/

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
