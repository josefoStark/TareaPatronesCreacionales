namespace PatronFactory
{
    /// <summary>
    /// Cuenta de nómina.
    /// </summary>
    /// <seealso cref="PatronFactory.IAccount" />
    public class CuentaNomina : IAccount
    {
        /// <summary>
        /// Número de la cuenta.
        /// </summary>
        private readonly int _numCuenta;

        /// <summary>
        /// Retiro de fondos.
        /// </summary>
        /// <param name="fondo">Cantidad a retirar.</param>
        /// <returns>
        /// Mensaje desplegado
        /// </returns>
        public string RetirarFondos(float fondo)
        {
            return $"El cliente hizo un retiro de ${fondo} de la cuenta {_numCuenta} de NOMINA";
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CuentaNomina"/>.
        /// </summary>
        /// <param name="numCuenta">Número de cuenta.</param>
        public CuentaNomina(int numCuenta)
        {
            _numCuenta = numCuenta;
        }
    }
}
