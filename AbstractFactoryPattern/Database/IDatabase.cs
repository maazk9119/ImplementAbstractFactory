using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Database
{
    public interface IDatabase
    {
        void InitailizeInstance(DatabaseType databaseType, string connectionString);
    }
}
