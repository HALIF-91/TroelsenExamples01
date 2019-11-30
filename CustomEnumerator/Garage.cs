using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }

        /*
        public IEnumerator GetEnumerator()
        {
            foreach (Car car in carArray)
            {
                yield return car;
            }
        }

        
             // При достижении оператора yield return производится сохранение текущего местоположения в
             // контейнере, а при следующем вызове итератора выполнение начинается с этого местоположения
        */
    }
}
