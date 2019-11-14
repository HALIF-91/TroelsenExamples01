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
        }
    }
}
