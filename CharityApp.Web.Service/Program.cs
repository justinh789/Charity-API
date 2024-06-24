using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace CharityApp.Web.Service
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                //.ConfigureServices(service => service.AddCors(options =>
                //{
                //    options.AddPolicy("AllowAll", policy =>
                //    {
                //        policy.AllowAnyOrigin()
                //            .AllowAnyHeader()
                //            .AllowAnyMethod();
                //    });
                //}))
                .ConfigureKestrel((context, serverOptions) =>
                {

                    // Set properties and call methods on serverOptions
                    

                });
         
         
    }
}
