using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityDb.Configuration
{
    public class PhieuMuonSachConfiguration : IEntityTypeConfiguration<PhieuMuonSach>
    {
        public void Configure(EntityTypeBuilder<PhieuMuonSach> builder)
        {
            builder.HasKey(p => p.MaPhieuMuon);
        }
    }
}
