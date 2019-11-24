using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Drive();
            }
            catch (Exception)
            {
                Console.WriteLine("Захват повторного исключения");
            }
            Console.ReadLine();
        }

        private static void Drive()
        {
            Car myCar = new Car("Rusty", 90);

            try
            {
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ErrorTimeStamp);
                Console.WriteLine(ex.CauseOfError);
                // не создается новый объект исключения, а просто передается исходный объект исключения
                throw;
            }
        }
    }
}
