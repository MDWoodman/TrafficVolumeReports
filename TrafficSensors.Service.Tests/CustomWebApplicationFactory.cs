using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TrafficSensors.Bus.BusApi;
using Microsoft.Extensions.Configuration;

namespace TrafficSensors.Service.Tests
{
    /// <summary>
    /// Custom factory for ReportsApi
    /// </summary>
    /// <typeparam name="TStartup"></typeparam>
    public class CustomWebApplicationFactory<TStartup, TDbContext, TDbContext2>
    : WebApplicationFactory<TStartup> 
        where TStartup : class 
        where TDbContext : DbContext
        where TDbContext2 : DbContext
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                var integrationConfig = new ConfigurationBuilder()
                    .AddJsonFile("reportsapi.appsettings.json")
                    .Build();

                config.AddConfiguration(integrationConfig);
            });

            builder.ConfigureServices(services =>
            {
                // Create a new service provider.
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();

                services.AddDbContext<TDbContext>((options, context) =>
                {
                    context.UseInMemoryDatabase("DB1")
                        .UseInternalServiceProvider(serviceProvider);
                });
                services.AddDbContext<TDbContext2>((options, context) =>
                {
                    context.UseInMemoryDatabase("DB2")
                        .UseInternalServiceProvider(serviceProvider);
                });

                services.AddTransient<IBusApi, TestBusApi>();

                // Build the service provider.
                var sp = services.BuildServiceProvider();

                // Create a scope to obtain a reference to the database
                // context (ApplicationDbContext).
                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<TDbContext>();

                    // Ensure the database is deleted and created.
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    var db2 = scopedServices.GetRequiredService<TDbContext2>();

                    // Ensure the database is deleted and created.
                    db2.Database.EnsureDeleted();
                    db2.Database.EnsureCreated();
                }
            });
        }
    }
}
