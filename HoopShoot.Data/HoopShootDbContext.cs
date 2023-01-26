using HoopShoot.Data.Configuration;
using HoopShoot.Data.Contracts;
using HoopShoot.Models;
using Microsoft.EntityFrameworkCore;

namespace HoopShoot.Data
{
    public class HoopShootDbContext : DbContext, IHoopShootDbContext
    {
        public HoopShootDbContext(DbContextOptions<HoopShootDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Team>(new TeamConfiguration());

        }

        DbSet<Team> Teams { get; set; }
        DbSet<Match> Matches { get; set; }
        DbSet<FullMatchInfo> fullMatchInfos { get; set; }
    }
}
