using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new Radio();
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if(carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if(CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    // Создать локальную переменную перед генерацией объекта Exception
                    // чтобы можно было обращаться к свойству HelpLink
                    CarIsDeadException ex =
                        new CarIsDeadException(string.Format("{0} has overhated!", PetName),
                        "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "https://metanit.com";

                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
