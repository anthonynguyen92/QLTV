using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityDb.Configuration
{
    public class ChiTietPhieuMuonConfiguration : IEntityTypeConfiguration<ChiTietPhieuMuon>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuMuon> builder)
        {
            builder.HasKey(p => new { p.MaPhieuMuon, p.MaSach });
            builder.HasOne(p => p.PhieuMuonSach).WithMany(x => x.chiTietPhieuMuon).HasForeignKey(k => k.MaPhieuMuon);
            builder.HasOne(p => p.Sach).WithMany(x => x.chiTietPhieuMuon).HasForeignKey(k => k.MaSach);

        }
    }
}
