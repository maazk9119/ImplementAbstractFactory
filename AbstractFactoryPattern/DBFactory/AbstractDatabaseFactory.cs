using AbstractFactoryPattern.Database;
using System;
using System.Data.Common;

namespace AbstractFactoryPattern.DBFactory
{
    internal abstract class AbstractDatabaseFactory
    {
        protected abstract string _factoryName { get; }

        public abstract DbProviderFactory CreateFactory();

        protected DbProviderFactory _factoryObject;

        internal virtual DbProviderFactory Factory => _factoryObject;

        public static DbProviderFactory CreateDatabse(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.SQL:
                    return new SqlFactory().CreateFactory();

                case DatabaseType.MySql:
                    return new MySqlFactory().CreateFactory();

                case DatabaseType.Oracle:
                    return new OracleFactory().CreateFactory();

                default:
                    throw new Exception("This Database type is not implemented");
            }
        }
    }
}
