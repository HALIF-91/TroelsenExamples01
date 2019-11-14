using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowSystemDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($"Number of processors: {Environment.ProcessorCount}");
            Console.WriteLine($".NET Version: {Environment.Version}");
            Console.WriteLine($"Version of OS is 64Bit: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Current machine name: {Environment.MachineName}");
            Console.WriteLine($"System Catalog path: {Environment.SystemDirectory}");
            Console.WriteLine($"UserName: {Environment.UserName}");
            Console.WriteLine($"NewLine symbol: {Environment.NewLine}");
            Console.WriteLine($"ReturnCode of App: {Environment.ExitCode}");

            Console.ReadLine();
        }
    }
}
