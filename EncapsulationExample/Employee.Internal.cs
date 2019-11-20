using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    partial class Employee
    {
        private int id;
        private string name;
        private int age;
        private float pay;
        private string empSSN;
        protected BenefitPackage empBenefits = new BenefitPackage();
        public Employee() { }
        public Employee(int id, string name, float pay) : this(name, id, 0, 0, null) { }
        public Employee(string name, int id, int age, float pay, string ssn)
        {
            Name = name; Id = id; Age = age;
            Pay = pay; empSSN = ssn;
        }
    }
}
