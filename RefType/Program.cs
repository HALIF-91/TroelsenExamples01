using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType
{
    class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name; this.age = age;
        }
        public Person()
        {

        }
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person fred = new Person("Fred", 12);
            fred.Display();

            SendAPersonByValue(fred);
            fred.Display();
            Console.Read();
        }

        private static void SendAPersonByValue(Person p)
        {
            p.age = 99;
            p = new Person("Nikki", 25);
        }
    }
}
