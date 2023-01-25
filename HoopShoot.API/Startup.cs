using HoopShoot.Data;
using Microsoft.EntityFrameworkCore;

namespace HoopShoot.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HoopShootDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("HoopShootDb")));
        }
    }
}
