using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon octagon = new Octagon();
            IDrawToForm form = octagon;
            form.Draw();

            IDrawToMemory memory = octagon;
            memory.Draw();

            IDrawToPrinter printer = octagon;
            printer.Draw();

            // Сокращенная нотация, если переменная интерфейса не нужна
            ((IDrawToPrinter)octagon).Draw();

            // Можно было бы также использовать ключевое слово as
            if (octagon is IDrawToMemory)
                ((IDrawToMemory)octagon).Draw();
            Console.ReadLine();
        }
    }
}
