using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Configuration
{
    public class PhieuMuonSachConfiguration : IEntityTypeConfiguration<PhieuMuonSach>
    {
        public void Configure(EntityTypeBuilder<PhieuMuonSach> builder)
        {
            builder.HasKey(p => p.MaPhieuMuon);
            builder.HasMany(p => p.Sach).WithOne(s => s.PhieuMuonsach).HasForeignKey(p => p.MaPhieuMuon);
        }
    }
}
