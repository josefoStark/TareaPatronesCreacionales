using System;

namespace PatronAbstractFactory
{
    public class Cliente
    {
        public void Main()
        {
            Console.WriteLine("\n*************** ABSTRACT FACTORY ***************");
            Console.WriteLine("Obteniendo figuras sin redondear");
            ClientMethod(new ShapeFactory());
            Console.WriteLine();

            Console.WriteLine("Obteniendo figuras redondeadas");
            ClientMethod(new RoundedShapeFactory());

            Console.ReadKey();
        }

        private void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.GetShape();
            var productB = factory.GetRoundedShape();

            productA.Draw();
            productB.Draw();
      
        }

    }
}
