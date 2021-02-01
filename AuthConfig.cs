using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace SecureClient
{
    public class AuthConfig
    {
        public string Instance { get; set; }
        public string TenantId { get; set; }
        public string ClientId { get; set; }

        public string Authority => String.Format(CultureInfo.InvariantCulture, Instance, TenantId);

        public string ClientSecret { get; set; }
        public string BaseAddress { get; set; }
        public string MyProperty { get; set; }
        public string ResourceId { get; set; }

        public static AuthConfig ReadJsonFromFile(string path)
        {
            //Console.WriteLine($"{Directory.GetCurrentDirectory()}{path}");

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(path);
            IConfiguration configuration = builder.Build();

            return configuration.Get<AuthConfig>();
        }


    }

}
