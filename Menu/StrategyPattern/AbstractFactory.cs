using PatronAbstractFactory;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón Abstract Factory.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class AbstractFactory : IPattern
    {
        /// <summary>
        /// Ejecuta la aplicación correspondiente al patrón de diseño .
        /// </summary>
        public void Execute()
        {
            new Cliente().Main();
        }
    }
}
