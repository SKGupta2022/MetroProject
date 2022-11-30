using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaipurMetroAdmin.Framework
{
    public abstract class AsyncDbRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;

        protected AsyncDbRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        }

        protected async Task<T> WithConnection<T>(Func<DbConnection, Task<T>> execute)
        {
            using (var connection = _connectionFactory.GetConnection())
            {
                await connection.OpenAsync();
                return await execute(connection);
            }
        }
    }
}
