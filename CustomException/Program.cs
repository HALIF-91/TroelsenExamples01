using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
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
            }
            Console.ReadLine();
        }
    }
}
