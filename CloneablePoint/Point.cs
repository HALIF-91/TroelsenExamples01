using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public Point(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }
        public Point(int xPos, int yPos, string petName) : this(xPos, yPos)
        {
            desc.PetName = petName;
        }
        public Point() { }
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nId = {3}\n", X, Y, desc.PetName, desc.PointId);
        }

        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();

            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
        /*
         При наличии класса или структуры, содержащей только типы значений, необходимо реализовать метод 
            Clone() с использованием MemberwiseClone(). Однако если имеется специальный тип, 
            поддерживающий ссылочные типы, для построения "глубокой копии" потребуется создание нового 
            объекта, который учитывает каждую переменную-член ссылочного типа
         */
    }
}
