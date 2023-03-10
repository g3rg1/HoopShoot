using HoopShoot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HoopShoot.Data.Configuration
{
    public class FullMatchInfoConfiguration : IEntityTypeConfiguration<FullMatchInfo>
    {
        public void Configure(EntityTypeBuilder<FullMatchInfo> builder)
        {
            builder.HasNoKey().ToView(null);
        }
    }
}
