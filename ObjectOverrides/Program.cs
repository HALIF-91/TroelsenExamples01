using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jimmy");
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash Code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            Person p2 = p1;
            object o = p2;

            if(o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine(p2.GetHashCode() + " = " + p1.GetHashCode());
                Console.WriteLine("Same instance!\n");
            }

            // Clone() вызывает метод protected MemberwiseClone()
            Person p3 = p1.Clone() as Person;
            if(p3 != null)
            {
                
                Console.WriteLine(p1.Name + " = " + p3.Name);
            }
            
            Console.ReadLine();
        }

    }
}
