using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();
            foreach (var part in carLot)
            {
                Car[] cars = part as Car[];
                Radio[] radios = part as Radio[];

                if (cars != null)
                    foreach (Car car in cars)
                        Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");

                Console.WriteLine();

                if (radios != null)
                    foreach (Radio radio in radios)
                        Console.WriteLine($"radio has numb: {radio.Numb}");
            }
            //
            Console.ReadLine();
        }
    }
}
