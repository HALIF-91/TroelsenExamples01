using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
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
                    Exception ex = new Exception($"{PetName} has overheated");
                    ex.HelpLink = "https://www.metanit.com";

                    // Указать специальные данные, касающиеся ошибки
                    ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}"); // метка времени
                    ex.Data.Add("Because", String.Format("You have a lead foot"));

                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
