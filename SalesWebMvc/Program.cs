using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SalesWebMvc.Data;

namespace SalesWebMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Re-creating Database
            using (SalesWebMvcContext db = new SalesWebMvcContext(new Microsoft.EntityFrameworkCore.DbContextOptions<SalesWebMvcContext>()))
            {/*
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                if (db.Database.CanConnect())
                {
                    Console.WriteLine("DB Connected");
                    var dep = db.Department.Add(new Models.Department { Name="Department 1" }).Entity;

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }

                    db.Department.Where(x => x.Name == "Department 1").ToString();
                }
                */
            }

            CreateHostBuilder(args).Build().Run();            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
