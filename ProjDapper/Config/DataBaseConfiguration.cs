﻿using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ProjDapper.Config
{
    public class DataBaseConfiguration
    {
        public static IConfigurationRoot Configuration { get; set; }
        public static string Get()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            string _con = Configuration["ConnectionStrings:DefaultConnection"];

            return _con;
        }
    }
}
