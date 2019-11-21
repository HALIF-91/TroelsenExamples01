using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsObject
{
    class Program
    {
        static void Main(string[] args)
        {
            object frank = new Manager("Frank Zappa", 5);

            Employee moonUnit = new Manager("MoonUnit Zappa", 1);

            SalesPerson jill = new PTSalesPerson("Jill", 90);

            GivePromotion(moonUnit);
            GivePromotion(jill);
            GivePromotion((Manager)frank);

            // Код скомпилируется, но вызывает ошибку во время выполнения
            // невозможно объект frank привести в Hexagon, необходимо обернуть в try catch
            // Hexagon hex = (Hexagon)frank;

            // as, когда используется это ключевое слово, если не удастся привести в нужный тип
            // возвращается null, приложение не сломается
            Hexagon hex = frank as Hexagon;
            if(hex == null)
                Console.WriteLine("Sorry, frank is not a Hexagon...");

            Console.ReadLine();
        }
        static void GivePromotion(Employee emp)
        {
            // Console.WriteLine("{0} was promoted!", emp.Name);

            // is возвращает true если объект является
            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
            else if(emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
        }
    }
}
