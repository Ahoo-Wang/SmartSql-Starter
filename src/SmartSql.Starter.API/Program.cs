﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SmartSql.Starter.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "SmartSql.Starter.API";
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var config = new ConfigurationBuilder()
                        .AddCommandLine(args)
                        .Build();
            return WebHost.CreateDefaultBuilder(args)
                  .UseConfiguration(config)
                  .UseStartup<Startup>()
                  .Build();
        }
    }
}
