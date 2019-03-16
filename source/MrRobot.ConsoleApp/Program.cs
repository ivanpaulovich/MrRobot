namespace MrRobot.ConsoleApp
{
    using System;
    using System.IO;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using MrRobot.Core.Entities;
    using MrRobot.Infrastructure.EntityFrameworkDataAccess;

    class Program
    {
        static void Main(string[] args)
        {
            Presenter presenter = new Presenter();
            var entitiesFactory = new EntitiesFactory();
            var builder = new DbContextOptionsBuilder<MrRobotContext>();
            builder.UseSqlServer(ReadDefaultConnectionStringFromAppSettings());
            builder.UseQueryTrackingBehavior(Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking);

            var context = new MrRobotContext(builder.Options);
            var locationGateway = new LocationGateway(context);
            var clean = new Core.UseCases.Clean(presenter, locationGateway, entitiesFactory);
            Startup startup = new Startup(clean);
            startup.Clean();
        }

        private static string ReadDefaultConnectionStringFromAppSettings()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }
    }
}