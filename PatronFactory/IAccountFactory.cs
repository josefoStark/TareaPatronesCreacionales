namespace PatronFactory
{
    /// <summary>
    ///Interfaz de la fábrica de cuentas.
    /// </summary>
    public interface IAccountFactory
    {
        /// <summary>
        /// Crear la instancia de una nueva cuenta.
        /// </summary>
        /// <param name="numCuenta">Número de cuenta.</param>
        /// <returns>Cuenta.</returns>
        IAccount CrearInstancia(int numCuenta);
    }
}
