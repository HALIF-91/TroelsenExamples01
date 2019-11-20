using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    class ThreeDCircle : Circle
    {
        // скрыть свойство PetName определенное выше в иерархии
        public new int PetName { get; set; }

        // скрыть метод Draw() определенное выше в иерархии
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
