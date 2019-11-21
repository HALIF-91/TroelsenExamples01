using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Person : Organism
    {
        public int Age { get; set; }
        public Person(string fName, string lName, int personAge) : base(fName, lName)
        {
            Age = personAge;
        }
        public Person() { }
        public override string ToString()
        {
            string myState = base.ToString();
            string str = string.Format(" Age: {0};", Age);

            return myState.Insert(myState.Length - 1, str);
        }

        public override bool Equals(object obj)
        {
            //if(obj != null && obj is Person)
            //{
            //    Person temp = (Person)obj;
            //    if (temp.FirstName == FirstName
            //        && temp.LastName == LastName
            //        && temp.Age == Age)
            //        return true;
            //}
            //return false;
            return obj.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
