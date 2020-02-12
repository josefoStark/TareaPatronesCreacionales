using PatronFactory;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón Factory.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class Factory : IPattern
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
