using System;
using System.Collections.Generic;
using System.Text;
using TenisWebsite.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenisWebsite.Data.Sql.DAOConfigurations
{
    class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.Property(c => c.SeasonId).IsRequired();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.active_bit).IsRequired();

        }
    }
}
