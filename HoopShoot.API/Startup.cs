using AutoMapper;
using HoopShoot.Data;
using HoopShoot.Data.Contracts;
using HoopShoot.Services.MappingProfiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection;

namespace HoopShoot.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HoopShootDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("HoopShootDb")));

            services.AddScoped<IHoopShootDbContext, HoopShootDbContext>();

            //register services using reflection.
            this.RegisterServices(services);

            //Automapper
            AutoMapper.IConfigurationProvider config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            services.AddSingleton(config);
            services.AddScoped<IMapper, Mapper>();
        }

        public void SeedData(IServiceCollection services)
        {

            var dbContext = services.BuildServiceProvider().GetService<IHoopShootDbContext>();

            if (dbContext!= null && !dbContext.Database.GetService<IRelationalDatabaseCreator>().Exists())
            {
                dbContext.Database.Migrate();
                dbContext.Database.ExecuteSqlRaw("EXEC spSeedTeamsData");
                dbContext.Database.ExecuteSqlRaw("EXEC spSeedMatchesData");
            }
        }

        public void RegisterServices(IServiceCollection services)
        {
            var servicesToRegister = Assembly
                .Load("HoopShoot.Services")
                .GetTypes()
                .Where(x => x.IsClass && x.Name.Contains("Service"))
                .Select(s => new { Interface = s.GetInterface($"I{s.Name}"), Implementation = s })
                .ToList();

            foreach (var type in servicesToRegister)
            {
                services.AddScoped(type.Interface, type.Implementation);
            }
        }
    }
}
