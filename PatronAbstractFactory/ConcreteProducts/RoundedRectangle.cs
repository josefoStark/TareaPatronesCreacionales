using System;

namespace PatronAbstractFactory
{
    public class RoundedRectangle : IRectangle
    {
        public void Draw()
        {
            Console.WriteLine("Pintando rectángulo redondeado");
        }
    }
}
