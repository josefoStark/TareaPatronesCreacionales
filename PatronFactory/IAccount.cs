namespace PatronFactory
{
    /// <summary>
    /// Interfaz cuenta.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Retiro de fondos.
        /// </summary>
        /// <param name="fondo">Cantidad a retirar.</param>
        /// <returns>Mensaje desplegado</returns>
        string RetirarFondos(float fondo);
    }
}
