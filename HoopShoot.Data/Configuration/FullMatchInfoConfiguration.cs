using HoopShoot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoopShoot.Data.Configuration
{
    public class FullMatchInfoConfiguration : IEntityTypeConfiguration<FullMatchInfo>
    {
        public void Configure(EntityTypeBuilder<FullMatchInfo> builder)
        {
            builder.HasNoKey();
        }
    }
}
