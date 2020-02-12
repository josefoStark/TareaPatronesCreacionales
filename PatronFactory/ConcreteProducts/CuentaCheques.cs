namespace PatronFactory
{
    /// <summary>
    /// Cuenta de cheques.
    /// </summary>
    /// <seealso cref="PatronFactory.IAccount" />
    public class CuentaCheques : IAccount
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
            return $"El cliente hizo un retiro de ${fondo} de la cuenta {_numCuenta} de CHEQUES";
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CuentaCheques"/>.
        /// </summary>
        /// <param name="numCuenta">Número de cuenta.</param>
        public CuentaCheques(int numCuenta)
        {
            _numCuenta = numCuenta;
        }
    }
}
