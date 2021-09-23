using System.Data.Common;
using System.Data.OracleClient;

namespace AbstractFactoryPattern.DBFactory
{
    internal class OracleFactory : AbstractDatabaseFactory

    {
        protected override string _factoryName => "Oracle";

        public override DbProviderFactory CreateFactory()
        {
            DbProviderFactories.RegisterFactory(_factoryName, OracleClientFactory.Instance);
            _factoryObject = DbProviderFactories.GetFactory(_factoryName);

            return _factoryObject;
        }
    }
}
