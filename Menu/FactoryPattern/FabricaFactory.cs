using Menu.StrategyPattern;

namespace Menu.FactoryPattern
{
    /// <summary>
    /// Fábrica de Factory.
    /// </summary>
    /// <seealso cref="Menu.FactoryPattern.IFactory" />
    public class FabricaFactory : IFactory
    {
        /// <summary>
        /// Obtiene la instancia del patrón que se ejecutará.
        /// </summary>
        /// <returns>
        /// Patrón a ejecutarse.
        /// </returns>
        public IPattern GetInstance()
        {
            return new Factory();
        }
    }
}
