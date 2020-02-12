using System;

namespace PatronBuilder
{
    public class StringMySqlBuilder : IConnectionBuilder
    {
        private readonly ConnectionString _connectionString;
        private string _element;

        public StringMySqlBuilder()
        {
            _connectionString = new ConnectionString { TypeString = "MySql" };
            _element = string.Empty;
        }

        public ConnectionString GetConnectionString()
        {
            return _connectionString;
        }

        public void SetServer()
        {
            _element = Read("Server: ");
            _connectionString.Add($"Server={_element};");
        }

        public void SetTimeOut()
        {
            _element = Read("TimeOut: ");
            _connectionString.Add($"Connection Timeout={_element};");
        }

        public void SetUser()
        {
            _element = Read("User: ");
            _connectionString.Add($"Uid={_element};");
        }

        public void SetPassword()
        {
            _element = Read("Password: ");
            _connectionString.Add($"Pwd={_element};");
        }

        public void SetInitBase()
        {
            _element = Read("Base: ");
            _connectionString.Add($"Database={_element};");
        }

        public void SetTrustedConnecction()
        {
            _element = Read("TrustedConnection: ");
            _connectionString.Add(_element);
        }

        private string Read(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}