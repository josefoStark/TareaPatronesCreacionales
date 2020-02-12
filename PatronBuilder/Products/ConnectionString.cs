

namespace PatronBuilder
{
    public class ConnectionString
    {
        public ConnectionString()
        {
            Cadena = string.Empty;
        }

        public void Add(string element)
        {
            Cadena = string.Concat(Cadena, element);
        }

        public string Cadena { get; private set; }

        public string TypeString { get; set; }

    }
}
