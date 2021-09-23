using System.Data.Common;
using MySql.Data.MySqlClient;

namespace AbstractFactoryPattern.DBFactory
{
    internal class MySqlFactory : AbstractDatabaseFactory
    {
        protected override string _factoryName => "MySql";

        public override DbProviderFactory CreateFactory()
        {
            DbProviderFactories.RegisterFactory(_factoryName, MySqlClientFactory.Instance);
            _factoryObject = DbProviderFactories.GetFactory(_factoryName);

            return _factoryObject;
        }
    }
}
