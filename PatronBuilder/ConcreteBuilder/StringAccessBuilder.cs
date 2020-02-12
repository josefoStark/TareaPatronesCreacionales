using System;

namespace PatronBuilder
{
    public class StringAccessBuilder : IConnectionBuilder
    {
        private readonly ConnectionString _connectionString;
        private string _element;

        public StringAccessBuilder()
        {
            _connectionString = new ConnectionString { TypeString = "Access" };
            _element = string.Empty;
        }

        public ConnectionString GetConnectionString()
        {
            return _connectionString;
        }

        public void SetServer()
        {

            _element = Read("Provider: ");
            _connectionString.Add($"Provider={_element};");
        }

        public void SetTimeOut()
        {
            _connectionString.Add(string.Empty);
        }

        public void SetUser()
        {
            _connectionString.Add(string.Empty);
        }

        public void SetPassword()
        {
            _element = Read("Password: ");
            _connectionString.Add($"Jet OLEDB:Database Password={_element};");
        }

        public void SetInitBase()
        {
            _element = Read("Data Source=: ");
            _connectionString.Add($"Jet OLEDB:Database Password={_element};");
        }

        public void SetTrustedConnecction()
        {
            _connectionString.Add(string.Empty);
        }

        private string Read(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}