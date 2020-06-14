using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityDb.Configuration
{
    public class PhieuThuTienConfiguration : IEntityTypeConfiguration<PhieuThuTien>
    {
        public void Configure(EntityTypeBuilder<PhieuThuTien> builder)
        {
            builder.HasKey(p => p.MaPhieuThuTien);
            builder.HasOne(p => p.DocGia).WithMany(x => x.PhieuThuTien).HasForeignKey(k => k.MaDocGia);
        }
    }
}
