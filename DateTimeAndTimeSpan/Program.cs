using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Dates and Times");

            // Этот конструктор принимает год, месц и день
            DateTime dateTime = new DateTime(2011, 10, 17);

            Console.WriteLine("The day of {0} is {1}", dateTime.Date, dateTime.DayOfWeek);

            // Проверка попадет ли данный экземпляр в диапазон летнего времени для текущего часового пояса
            Console.WriteLine("Daylight savings: {0}",  dateTime.IsDaylightSavingTime());

            // Сеейчас месц декабрь
            dateTime = dateTime.AddMonths(2);

            Console.WriteLine("\nThe day of {0}", dateTime.Date);
            // Проверка попадет ли данный экземпляр в диапазон летнего времени для текущего часового пояса
            Console.WriteLine("Daylight savings: {0}",  dateTime.IsDaylightSavingTime());

            // Этот конструктор принимает часы, минуты и секунды
            TimeSpan timeSpan = new TimeSpan(4, 30, 0);
            Console.WriteLine(timeSpan);

            // Вычесть 15 минут из текущего TimeSpan и вывести результат
            Console.WriteLine(timeSpan.Subtract(new TimeSpan(0, 15, 0)));

            Console.ReadLine();
        }
    }
}
