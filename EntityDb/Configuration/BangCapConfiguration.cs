using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Configuration
{
    public class BangCapConfiguration : IEntityTypeConfiguration<BangCap>
    {
        public void Configure(EntityTypeBuilder<BangCap> builder)
        {
            builder.HasKey(p => p.MaBang);
        }
    }
}
