using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceHierarchy
{
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
