namespace PatronFactory
{
    public class CuentaChequesFactory : IAccountFactory
    {
        public IAccount CrearInstancia(int cuenta)
        {
            return new CuentaCheques(cuenta);
        }
    }
}
