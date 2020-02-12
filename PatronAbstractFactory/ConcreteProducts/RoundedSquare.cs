using System;

namespace PatronAbstractFactory
{
    public class RoundedSquare : ISquare
    {
        public void Draw()
        {
            Console.WriteLine("Pintando cuadrado redondeado.");
        }
    }
}
