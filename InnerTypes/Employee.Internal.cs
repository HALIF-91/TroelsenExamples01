using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypes
{
    abstract partial class Employee
    {
        public float Pay { get; set; }
        public string EmpSSN { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, 0, null) { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name; Id = id; Age = age;
            Pay = pay; EmpSSN = ssn;
        }
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", EmpSSN);
        }
    }
}
