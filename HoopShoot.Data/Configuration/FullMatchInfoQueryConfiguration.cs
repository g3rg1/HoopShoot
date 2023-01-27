using HoopShoot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HoopShoot.Data.Configuration
{
    public class FullMatchInfoQueryConfiguration : IEntityTypeConfiguration<FullMatchInfoQuery>
    {
        public void Configure(EntityTypeBuilder<FullMatchInfoQuery> builder)
        {
            builder.HasNoKey().ToView(null);
        }
    }
}
