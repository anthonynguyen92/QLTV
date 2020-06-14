using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
