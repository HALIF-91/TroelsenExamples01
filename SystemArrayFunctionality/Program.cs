using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemArrayFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
            
            Console.WriteLine("-> Here is the array:");
            foreach (string band in gothicBands)
            {
                Console.Write(band + ", ");
            }
            Console.WriteLine("\n");

            // Reverse()
            // gothicBands.Reverse() не изменяет порядок массива, а создает новую копию
            // string[] strArray = gothicBands.Reverse() необходимо присвоить другому массиву
            Array.Reverse(gothicBands);

            Console.WriteLine("-> The reversed array");
            foreach (string band in gothicBands)
            {
                Console.Write(band + ", ");
            }
            Console.WriteLine("\n");

            // Clear()
            // размер массива не изменяется, очищенные элементы заменяются базовым значением
            // 0 - для чисел, null - для объектных ссылок, false - для булевых выражений
            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);

            foreach (string band in gothicBands)
            {
                Console.Write(band + ", ");
            }

            Console.ReadLine();
        }
    }
}
