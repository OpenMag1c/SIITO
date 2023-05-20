using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Client
{
    internal static class Program
    {
        public static DbContextOptions<AppDbContext> ContextOptions;
        public static IConfigurationRoot Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = Configuration.GetConnectionString("SqlServerConnection");

            ContextOptions = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString).Options;

            Environment.SetEnvironmentVariable("EPPlusLicenseContext", "NonCommercial");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}