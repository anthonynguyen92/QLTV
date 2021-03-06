﻿using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityDb.Configuration
{
    public class DocGiaConfiguration : IEntityTypeConfiguration<DocGia>
    {
        public void Configure(EntityTypeBuilder<DocGia> builder)
        {
            builder.HasKey(m => m.MaDocGia);
            builder.HasOne(m => m.phieuMuaSach).WithMany(p => p.DocGia).HasForeignKey(f => f.MaPhieuMuon);
        }
    }
}
