using AbstractFactoryPattern.DBFactory;
using System;
using System.Data.Common;

namespace AbstractFactoryPattern.Database
{
    public class Database : IDatabase
    {
        private static Database database;
        public static IDatabase Instance
        {
            get
            {
                if (database is null)
                {
                    database = new Database();
                }

                return database;
            }
        }

        private DatabaseType databaseType;
        private string connectionString;

        private DbProviderFactory Factory;

        private Database() { }

        public void InitailizeInstance(DatabaseType databaseType, string connectionString)
        {
            this.databaseType = databaseType;
            this.connectionString = connectionString;

            Factory = AbstractDatabaseFactory.CreateDatabse(this.databaseType);
        }
    }
}
