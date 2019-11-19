using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    class Employee
    {
        private int id;
        private string name;
        private int age;
        private float pay;
        private string empSSN;
        public Employee() { }
        public Employee(int id, string name, float pay) : this(id, name, 0, 0, null) { }
        public Employee(int id, string name, int age, float pay, string ssn)
        {
            Name = name; Id = id; Age = age;
            Pay = pay; empSSN = ssn;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public float Pay
        {
            get { return pay; }
            set { pay = value; }
        }
        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public void GiveBonus(float amount) { Pay += amount; }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {1}", Id);
            Console.WriteLine("Age: {2}", Age);
            Console.WriteLine("Pay: {3}", Pay);
        }
    }
}
