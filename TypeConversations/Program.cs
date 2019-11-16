using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversations
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 100;
            byte b2 = 250;

            try
            {
                // проверка условий переполнения при арифметических операциях
                // макс значние для byte = 255 
                checked
                {
                    // or like this checked((byte)Add(b1, b2))
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        private static int Add(int b1, int b2)
        {
            return b1 + b2;
        }

        // unchecked, применяется когда переполнение является приемлемым и включена проверка переполнения (checked) на уровне всего проекта
        // свойства проекта -> сборка -> дополнительно -> (флажок) проверять переполнение и потерю значимости (на уровне всего проекта)
    }
}
