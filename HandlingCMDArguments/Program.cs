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

            foreach (var arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.ReadLine();

            // предоставить аргументы в командной строке
            // C:\HandlingCMDArguments\bin\Debug>HandlingCMDArguments.exe /arg1 -arg2 #arg3

            //Hello World
            //Arg: /arg1
            //Arg: -arg2
            //Arg: №arg3
        }
    }
}
