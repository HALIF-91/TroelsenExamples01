using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsObject
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
        public SalesPerson(string name, int number) : base(name)
        {
            SalesNumber = number;
        }

        // если переопределять метод Equals() то необходимо также переопределить метод GetHashCode()
        public override bool Equals(object obj)
        {
            SalesPerson sp = obj as SalesPerson;
            if(sp != null) // либо if(obj is SalesPerson)
            {
                if (this.Name == sp.Name && this.SalesNumber == sp.SalesNumber)
                    return true;
            }
            return false;
        }
    }
}
