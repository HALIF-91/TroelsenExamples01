using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Zippy", 20);
            car.CrankTunes(true);

            // Разогнаться до скорости, превышающей максимальный
            // предел автомобиля, для выдачи исключения
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    car.Accelerate(10);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Member name: {0}", ex.TargetSite); // имя члена вызвавшего исключение
                Console.WriteLine("Class defining member: {0}", 
                    ex.TargetSite.DeclaringType); // класс, определяющий член
                Console.WriteLine("Member type: {0}",
                    ex.TargetSite.MemberType); // тип члена
                Console.WriteLine("Message: {0}", ex.Message); // сообщение
                Console.WriteLine("Source: {0}", ex.Source); // источник

                // StackTrace отражает последовательность вызовов, которая привела к выдаче исключения
                Console.WriteLine("Stack: {0}", ex.StackTrace);
                Console.WriteLine("Help Link: {0}", ex.HelpLink); // ссылка для справки

                Console.WriteLine("\n-> Custom Data:");
                if(ex.Data != null)
                {
                    foreach (DictionaryEntry de in ex.Data)
                    {
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
