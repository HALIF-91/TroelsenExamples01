using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Using the StringBuilder:");

            // Создается объект по умолчанию с длиной не более 16 символов
            StringBuilder str = new StringBuilder("**** Fantastic Games ****");
            str.Append("\n");
            str.AppendLine("Half Life");
            str.AppendLine("Morowind");
            str.AppendLine("Deus Ex" + "2");
            str.AppendLine("System Shock");
            Console.WriteLine(str);

            str.Replace("2", " Invisible War");
            Console.WriteLine(str);
            Console.WriteLine("str has {0} chars.", str.Length);

            // Создать StringBuilder с исходным размером в 256 символов
            // если добавляется больше символов, StringBuilder скопирует свои данные в новый экземпляр и увеличит размер буфера
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);
            Console.ReadLine();
        }
    }
}
