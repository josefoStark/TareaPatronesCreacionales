using System;

namespace PatronFactory
{
    public class Cliente
    {
        public void Main()
        {
            Console.WriteLine("\n*************** FACTORY ***************");
            Console.WriteLine("Indique la cantidad a retirar:");
            float retiro = float.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la cuenta donde realizará el retiro:\n" +
                              " 1-Ahorro\n 2-Cheques\n 3-Nomina\n");

            int option = Convert.ToInt32(Console.ReadLine());
            IAccountFactory accountFactory = SelectFactory(option);

            if (accountFactory == null) return;

            int numAccount = new Random().Next(1000);
            IAccount cuenta = accountFactory.CrearInstancia(numAccount);
            Console.WriteLine(cuenta == null ? "Operación inválida" : cuenta.RetirarFondos(retiro));
        }

        private IAccountFactory SelectFactory(int option)
        {
            switch (option)
            {
                case 1:
                    return new CuentaChequesFactory();
                case 2:
                    return new CuentaAhorroFactory();
                case 3:
                    return new CuentaNominaFactory();
                default:
                    return null;
            }
        }
    }
}
