namespace ConsoleApp1
{
    internal class Hexagon : Shape
    {
        // override - значит переопределить
        public override void Draw()
        {
            System.Console.WriteLine("Я шестиугольник");
        }
    }
}