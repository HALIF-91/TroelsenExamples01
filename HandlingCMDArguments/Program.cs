using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingCMDArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получить аргументы с использованием System.Environment
            // string[] theArgs = Environment.GetCommandLineArgs();
            // первый элемент массива theArgs содержит имя приложения, остальные аргументы командной строки

            foreach (var arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.ReadLine();

            // предоставить аргументы в командной строке
            // C:\HandlingCMDArguments\bin\Debug>HandlingCMDArguments.exe /arg1 -arg2 #arg3

            // указать аргументы ком. строки (в целях тестирования) также можно в свойствах проекта (свойства -> отладка)

            //Hello World
            //Arg: /arg1
            //Arg: -arg2
            //Arg: #arg3
        }
    }
}
