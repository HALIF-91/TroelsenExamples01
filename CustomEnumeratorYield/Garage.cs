using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorYield
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];
        private Radio[] radios = new Radio[2];
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);

            radios[0] = new Radio(55);
            radios[1] = new Radio(88);
        }

        public IEnumerator GetEnumerator()
        {
            yield return carArray;
            yield return radios;

            /*
             При достижении оператора yield return производится сохранение текущего местоположения в
             контейнере, а при следующем вызове итератора выполнение начинается с этого местоположения
             */
        }
    }
}
