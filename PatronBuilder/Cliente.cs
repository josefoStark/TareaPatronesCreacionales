using System;

namespace PatronBuilder
{
    public class Cliente
    {
        public void Main()
        {
            Console.WriteLine("\n*************** BUILDER ***************");
            Console.WriteLine("Seleccione la cadena de conexión deseada:\n" +
                              " 1-Access\n 2-MySql\n 3-Sql Server\n");
            int option = Convert.ToInt32(Console.ReadLine());

            IConnectionBuilder builder = SelectBuilder(option);

            if (builder == null) return;

            Director director = new Director(builder);
            director.BuildConnection();
            ConnectionString connectionString = builder.GetConnectionString();

            Console.WriteLine($"\n {connectionString.TypeString} : {connectionString.Cadena}");
        }

        private IConnectionBuilder SelectBuilder(int option)
        {
            switch (option)
            {
                case 1:
                    return new StringAccessBuilder();
                case 2:
                    return new StringMySqlBuilder();
                case 3:
                    return new StringSqlBuilder();
                default:
                    return null;
            }
        }

    }
}
