using System;

namespace PatronAbstractFactory
{
    public class Rectangle : IRectangle
    {
        public void Draw()
        {
            Console.WriteLine("Pintando rectángulo");
        }
    }
}
