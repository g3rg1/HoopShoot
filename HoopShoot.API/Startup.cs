using HoopShoot.Data;
using HoopShoot.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

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
        }

        public void SeedData(IServiceCollection services)
        {

            var dbContext = services.BuildServiceProvider().GetService<IHoopShootDbContext>();

            var databaseExists = dbContext.Database.GetService<IRelationalDatabaseCreator>().Exists();

            if (!databaseExists)
            {
                dbContext.Database.Migrate();
                dbContext.Database.ExecuteSqlRaw("spSeedTeamsData");
                dbContext.Database.ExecuteSqlRaw("spSeedMatchesData");
            }
        }
    }
}
