using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Исполняющая система вызывает статический конструктор всего один раз для этого экземпляра приложения
            // когда создает первый раз экземпляр класса
            // или перед первым обращением к статическому члену этого класса 
            // (даже до того момента когда будет дана команда создать первый экземпляр класса)
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            // Создать счет
            SavingsAccount s1 = new SavingsAccount(50);

            // Вывести текущую процентную ставку
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            // изменение процентной ставки
            SavingsAccount.SetInterestRate(0.08);

            // Создать второй счет
            SavingsAccount s2 = new SavingsAccount(100);

            // Вывести текущую процентную ставку
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            Console.ReadLine();
        }
    }
}
