using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    class Program
    {
        enum Employee : byte
        {
            Manager = 10, Grunt = 1, Contractor = 100, VicePresident = 99
        }
        static void Main(string[] args)
        {
            Employee emp = Employee.Contractor;

            // Выводит строку "Contractor = 100"
            Console.WriteLine("{0} = {1}", emp, (byte)emp); // emp.ToString()

            // Вывести тип хранилища, используемый в перечислении
            Console.WriteLine("Employee uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("Employee uses a {0} for storage", Enum.GetUnderlyingType(typeof(Employee)));

            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            ConsoleColor consoleColor = ConsoleColor.Gray;

            EvaluateEnum(emp);
            EvaluateEnum(dayOfWeek);
            EvaluateEnum(consoleColor);
            Console.ReadLine();
        }

        private static void EvaluateEnum(Enum e)
        {
            Console.WriteLine("\n=> Information about {0}", e.GetType());

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            // Получить все пары "имя/значение" для входного параметра
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            // Вывести строковое имя и ассоциированное значение
            // используя флаг формата D
            foreach (var item in enumData)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", item);
            }
        }
    }
}
