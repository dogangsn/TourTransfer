﻿
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTransfer.Persistence
{
    public class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/TourTransfer.WebAPI"));
                configurationManager.AddJsonFile("appsettings.Local.json");
                return configurationManager.GetConnectionString("DefaultConnection");
            }
        }


    }
}
