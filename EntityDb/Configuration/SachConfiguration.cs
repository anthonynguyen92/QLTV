using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityDb.Configuration
{
    public class SachConfiguration : IEntityTypeConfiguration<Sach>
    {
        public void Configure(EntityTypeBuilder<Sach> builder)
        {
            builder.HasKey(p => p.MaSach);
        }
    }
}
