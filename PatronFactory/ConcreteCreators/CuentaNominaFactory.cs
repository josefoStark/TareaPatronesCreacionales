namespace PatronFactory
{
    public class CuentaNominaFactory : IAccountFactory
    {
        public IAccount CrearInstancia(int cuenta)
        {
            return new CuentaNomina(cuenta);
        }
    }
}
