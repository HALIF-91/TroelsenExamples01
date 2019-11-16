using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOnEnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favourite day of week: ");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return; // с помощью return мы говорим компилятору что код дальше не пойдет
                        // иначе ошибка, использование переменной (favDay) которой не присвоено значение
            }

            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!"); break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar"); break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed."); break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Footbal!"); break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday..."); break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday"); break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day."); break;
            }
            Console.ReadLine();
        }
    }
}
