using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        // чтобы избежать конфликта из за одинакового метода Draw() во всех интерфейсах, используется
        // явная реализации интерфейса, не указывается модификатор доступа
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }
    }
}
