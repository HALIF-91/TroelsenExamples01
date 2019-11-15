using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // выдать звуковой сигнал (ноту) указанной частоты и длительности
            Console.Beep(555, 1000);

            // устанавливает заголовок текущей консоли
            Console.Title = "Lenovo console";

            ConsoleColor defaultForegroundColor = Console.ForegroundColor;
            ConsoleColor defaultBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;

            // Эти свойства управляют высотой и шириной буферной области консоли
            Console.BufferHeight = 480;
            Console.BufferWidth = 640;

            // Размер консоли по отношению к установленному буферу
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            int top = Console.WindowTop;
            int left = Console.WindowLeft;

            Console.WriteLine($"{width}, {height}, {top}, {left}");
            Console.WriteLine("Hello World");

            Console.WindowWidth = width / 2;
            Console.WindowHeight = height / 2;

            Console.ForegroundColor = defaultForegroundColor;
            Console.BackgroundColor = defaultBackgroundColor;

            // Очищать установленный буфер и область отображения консоли
            // Console.Clear();
            Console.ReadLine();
        }
    }
}
