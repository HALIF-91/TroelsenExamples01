using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class DatabaseReader
    {
        // поле данных допускающих null
        public int? numericValue = null;
        public bool? boolValue = true;

        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // создание типов данных по значению принимающих null
            int? number = 10;
            double? fractional = 3.14;
            bool? state = null;
            char? symbol = 'a';
            int?[] array = new int?[10];

            // создание типов данных по значению принимающих null, другой способ
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] nullableArray = new int?[10];

            DatabaseReader reader = new DatabaseReader();

            int? i = reader.GetIntFromDatabase();
            if(i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i);
            else
                Console.WriteLine("Value of 'i' is undefined.");

            bool? b = reader.GetBoolFromDatabase();
            if(b != null)
                Console.WriteLine("Value of 'b' is: {0}", b.Value); // b.Value то же что и просто 'b'
            else
                Console.WriteLine("Value of 'b' is undefined.");

            // ??
            // Если значение, возвращаемое GetIntFromDatabase(),
            // равно null, присвоить локальной переменной значение 100
            int myData = reader.GetIntFromDatabase() ?? 100;
            Console.ReadLine();
        }
    }
}
