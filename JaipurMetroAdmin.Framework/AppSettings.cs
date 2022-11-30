using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JaipurMetroAdmin.Framework
{
    public class AppSettings : IAppSettings
    {
        public AppSettings()
        {
            var configuration = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", true)
                          .Build();

            DbConnection = configuration.GetConnectionString("DbConnection");
        }

        public string DbConnection { get; }
    }
}
