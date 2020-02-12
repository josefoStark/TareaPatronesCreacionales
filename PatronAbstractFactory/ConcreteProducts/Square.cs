using System;

namespace PatronAbstractFactory
{
    public class Square : ISquare
    {
        public void Draw()
        {
            Console.WriteLine("Pintando cuadrado");
        }
    }
}
