namespace PatronBuilder
{
    public interface IConnectionBuilder
    {
        ConnectionString GetConnectionString();

        void SetServer();

        void SetTimeOut();

        void SetUser();

        void SetPassword();

        void SetInitBase();

        void SetTrustedConnecction();

    }
}
