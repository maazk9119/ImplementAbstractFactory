using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace AbstractFactoryPattern.DBFactory
{
    internal class SqlFactory : AbstractDatabaseFactory
    {
        protected override string _factoryName => "SQL";    

        public override DbProviderFactory CreateFactory()
        {
            DbProviderFactories.RegisterFactory(_factoryName, SqlClientFactory.Instance);
            _factoryObject = DbProviderFactories.GetFactory(_factoryName);

            return _factoryObject;
        }
    }
}
