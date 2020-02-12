using PatronBuilder;

namespace Menu.StrategyPattern
{
    /// <summary>
    /// Patrón Builder.
    /// </summary>
    /// <seealso cref="Menu.StrategyPattern.IPattern" />
    public class Builder : IPattern
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
