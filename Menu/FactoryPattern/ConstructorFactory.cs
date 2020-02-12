using Menu.StrategyPattern;

namespace Menu.FactoryPattern
{
    /// <summary>
    /// Fábrica de Builder.
    /// </summary>
    /// <seealso cref="Menu.FactoryPattern.IFactory" />
    public class ConstructorFactory : IFactory
    {
        /// <summary>
        /// Obtiene la instancia del patrón que se ejecutará.
        /// </summary>
        /// <returns>
        /// Patrón a ejecutarse.
        /// </returns>
        public IPattern GetInstance()
        {
            return new Builder();
        }
    }
}
