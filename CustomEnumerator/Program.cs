using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();

            var i = carLot.GetEnumerator();

            while (i.MoveNext())
            {
                Car car = (Car)i.Current;
                Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");
            }
            Console.WriteLine();

            foreach (Car car in carLot)
            {
                Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");
            }
            Console.WriteLine();

            foreach (Car car in carLot.GetTheCars(true))
            {
                Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");
            }
            Console.ReadLine();
        }
    }
}

/*
 public interface IEnumerator
 {
    bool MoveNext();        // Переместить вперед внутреннюю позицию курсора
    object Current { get; } // Получить текущий элемент (свойство 
                            // доступное только для чтения).
    void Reset();           // Поместить курсор перед первым элементом
 }
     */