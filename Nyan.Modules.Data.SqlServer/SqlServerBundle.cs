﻿using Nyan.Core.Modules.Data.Connection;
using System.Collections.Generic;

namespace Nyan.Modules.Data.SqlServer
{
    public class SqlServerBundle : BundlePrimitive
    {
        private string _dbName = null;

        public SqlServerBundle()
        {
            Initialize();
        }

        public SqlServerBundle(string dbName)
        {
            Initialize(dbName);
        }

        private void Initialize(string dbName = "Nyan.SqlServer.db")
        {
            _dbName = dbName;

            AdapterType = typeof(SqlServerDataAdapter);
            EnvironmentCypherKeys = new Dictionary<string, string> { { "STD", "Data Source=.\\SQLEXPRESS;Initial Catalog=Nyan;Integrated Security=True" } };
        }

        public override void ValidateDatabase()
        {
            // throw new NotImplementedException();
        }
    }
}