namespace PatronBuilder
{
    public class Director
    {
        private readonly IConnectionBuilder _builder;

        public Director(IConnectionBuilder builder)
        {
            _builder = builder;
        }


        public void BuildConnection()
        {

            switch (_builder.GetType().Name)
            {
                case nameof(StringAccessBuilder):
                    _builder.SetServer();
                    _builder.SetInitBase();
                    _builder.SetPassword();
                    break;

                case nameof(StringMySqlBuilder):
                    _builder.SetServer();
                    _builder.SetInitBase();
                    _builder.SetUser();
                    _builder.SetPassword();
                    _builder.SetTimeOut();
                    break;

                case nameof(StringSqlBuilder):
                    _builder.SetServer();
                    _builder.SetInitBase();
                    _builder.SetUser();
                    _builder.SetPassword();
                    _builder.SetTrustedConnecction();
                    break;
            }

        }
    }

}

