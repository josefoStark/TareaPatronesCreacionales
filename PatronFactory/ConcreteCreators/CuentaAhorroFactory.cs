namespace PatronFactory
{
    public class CuentaAhorroFactory : IAccountFactory
    {
        public IAccount CrearInstancia(int cuenta)
        {
            return new CuentaAhorro(cuenta);
        }
    }
}
