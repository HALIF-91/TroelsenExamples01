using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Basic String Functionality:");
            string firstName = "Fred";
            string secondName = "Mazursky";

            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("Value of secondName: {0} \n", secondName);

            // Length 
            // Длина строки
            Console.WriteLine("firstName has {0} characters.", firstName.Length);

            // Equals() String.Compare() 
            // Провера содержатся ли в двух строковых объектах идентичные символьные данные
            Console.WriteLine("firstName is equals secondName: {0} or {1}", 
                firstName.Equals(secondName), String.Compare(firstName, secondName));

            // Insert() 
            // вставить строку внуть другой определенной строки
            Console.WriteLine("Everybody call him {0} \n", firstName.Insert(4, "dy"));

            // PadRight() PadLeft() 
            // Дополнение строки символом до достижения указанной длины, если символ не указан то будет выбран пробел
            firstName = firstName.PadRight(6, '#');
            firstName = firstName.PadLeft(8, '#');
            Console.WriteLine("His sister wrote his name in note {0}", firstName);

            // Trim()
            // Удалить все вхождения указзанных символов с начала и конца строки
            Console.WriteLine("\nIf we use trim: {0} \n", firstName.Trim(new char[] { '#' }));

            // Remove()
            // Replace()
            // получить копию строки с удалением или заменой символов
            Console.WriteLine("Value of firstName: {0}", firstName);

            string strRemove = firstName.Remove(0, 2);
            string strReplace = firstName.Replace("##", "");
            Console.WriteLine("After remove: {0}\n" +
                "After replace: {1}\n", strRemove, strReplace);

            // Split()
            // разделить строку на массив подстрок, по позиции указанных символов
            string str = "BigInteger";
            string[] array = str.Split(new char[] { 'e', 'i' });

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
