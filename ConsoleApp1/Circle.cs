namespace ConsoleApp1
{
    internal class Circle : Shape
    {
        // override - значит переопределить
        public override void Draw()
        {
            System.Console.WriteLine("Я круг");
        }
    }
}