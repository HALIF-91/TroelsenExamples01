using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage();
            
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999); // $99,999.00 для форматирования денежных значений, по умолчанию значение предваряется символом локальной валюты
            Console.WriteLine("d9 format: {0:d9}", 99999); // 000099999 указывает минимальное количество цифр для представления значения
            Console.WriteLine("f3 format: {0:f3}", 99999); // 99999.000
            Console.WriteLine("n format: {0:n}", 99999); // 99,999.00

            // Использование верхнего или нижнего регистра для x определяет, в каком регистре отображаются символы в шестнадцатеричном формате
            Console.WriteLine("E format: {0:E}", 99999); // 9.999900E+004
            Console.WriteLine("e format: {0:e}", 99999); // 9.999900e+004
            Console.WriteLine("X format: {0:X}", 99999); // 1869F
            Console.WriteLine("x format: {0:x}", 99999); // 1869f
            Console.ReadLine();
        }

        private static void DisplayMessage()
        {
            // Использование string.Format() для форматирования строкового литерала
            string userMessage = string.Format("100000 in  hex is {0:x}", 10000);

            // Для компиляции этой строки кода требуется
            // сслыка на PresentationFramework.dll
            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
