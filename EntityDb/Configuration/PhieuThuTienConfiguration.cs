using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Configuration
{
    public class PhieuThuTienConfiguration : IEntityTypeConfiguration<PhieuThuTien>
    {
        public void Configure(EntityTypeBuilder<PhieuThuTien> builder)
        {
            builder.HasKey(p => p.MaPhieuThuTien);
        }
    }
}
