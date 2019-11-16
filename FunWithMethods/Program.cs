using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Модификатор out
            // выходные параметры не нуждаются в инициализации перед передачей методу
            int answer;            
            Add(90, 90, out answer);
            Console.WriteLine("90 + 90 = {0}\n", answer);

            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}\n" +
                "String is: {1}\n" +
                "Boolean is: {2}\n", i, str, b);

            // Модификатор ref
            // ссылочные параметры должны быть инициализированы перед передачей методу
            string str1 = "Flip";
            string str2 = "Flop";

            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);

            // Модификатор params
            double average;

            // Передать список значений double
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            // или передать массив значений double
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            // или не передавать ничего
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.ReadLine();
        }

        private static double CalculateAverage(params double[] values)
        {
            double sum = 0;
            if (values.Length == 0)
                return sum;
            foreach (var value in values)
            {
                sum += value;
            }
            return (sum / values.Length);
        }

        private static void SwapStrings(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            // если не присвоить значение хоть одной переменной, будет ошибка
            a = 9; b = "Mister Beck"; c = true;
        }

        private static void Add(int x, int y, out int answer)
        {
            // если не присвоить значение для answer, будет ошибка
            answer = x + y;
        }
    }
}
