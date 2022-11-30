using JaipurMetroAdmin.Framework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Repository
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly IAppSettings _configuration;

        public DbConnectionFactory(IAppSettings configuration)
        {
            _configuration = configuration;
        }

        public DbConnection GetConnection()
        {
            var connectionString = _configuration.DbConnection;

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new Exception($"Could not create a connection string");

            return new SqlConnection(connectionString);
        }


    }
}
