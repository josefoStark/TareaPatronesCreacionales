using System;

namespace PatronBuilder
{
    public class StringSqlBuilder : IConnectionBuilder
    {
        private ConnectionString _connectionString;
        private string _element;

        public StringSqlBuilder()
        {
            _connectionString = new ConnectionString {TypeString = "SQL Server"};
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
            _connectionString.Add(_element);
        }

        public void SetUser()
        {
            _element = Read("User: ");
            _connectionString.Add($" User Id={_element};");
        }

        public void SetPassword()
        {
            _element = Read("Password: ");
            _connectionString.Add($"Password={_element};");
        }

        public void SetInitBase()
        {
            _element = Read("Base: ");
            _connectionString.Add($"Database={_element};");
        }

        public void SetTrustedConnecction()
        {
            _element = Read("TrustedConnection: ");
            _connectionString.Add($"Trusted Connection ={_element};");
        }

        private string Read(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public void ShowString()
        {
            Console.WriteLine($"\n {_connectionString.Cadena}");
        }
    }
}