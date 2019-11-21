using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal abstract class Organism
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Organism(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
        public Organism() { }
        public override string ToString()
        {
            string myState;
            // брать в квадратные скобки и разделять точкой с запятой рекомендованный формат
            myState = string.Format("[First Name: {0}; Last Name: {1};]", FirstName, LastName);
            return myState;
        }
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
    }
}
