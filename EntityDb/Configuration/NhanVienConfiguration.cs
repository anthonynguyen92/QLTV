using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityDb.Configuration
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasKey(f => f.MaNhanVien);
            builder.HasOne(p => p.PhieuThuTien).WithMany(f => f.nhanViens).HasForeignKey(k => k.MaPhieuThuTien);
        }
    }
}
