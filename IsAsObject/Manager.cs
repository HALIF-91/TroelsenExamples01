using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsObject
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager(string name, int options) : base(name)
        {
            StockOptions = options;
        }

        // если переопределять метод Equals() то необходимо также переопределить метод GetHashCode()
        public override bool Equals(object obj)
        {
            Manager man = obj as Manager;
            if(man != null) // либо if(obj is Manager)
            {
                if (man.Name == this.Name && man.StockOptions == this.StockOptions)
                    return true;
            }
            return false;
        }
    }
}
