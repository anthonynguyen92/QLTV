using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Configuration
{
    public class PhieuMuaSachConfiguration : IEntityTypeConfiguration<PhieuMuaSach>
    {
        public void Configure(EntityTypeBuilder<PhieuMuaSach> builder)
        {
            builder.HasKey(p => p.MaPhieuMua);
            builder.HasMany(p => p.Sach).WithOne(s => s.PhieuMuonsach).HasForeignKey(p => p.MaPhieuMuon);
        }
    }
}
