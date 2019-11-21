namespace IsAsObject
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }
        public Employee() { }

        // если переопределять метод Equals() то необходимо также переопределить метод GetHashCode()
        public abstract override bool Equals(object obj);
    }
}