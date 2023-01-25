using HoopShoot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HoopShoot.Data.Configuration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        private const int MaxNameLenght = 50;

        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
               .Property(f => f.Name)
               .HasMaxLength(MaxNameLenght)
               .IsRequired();
        }
    }
}
