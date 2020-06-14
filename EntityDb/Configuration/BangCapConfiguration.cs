using EntityDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityDb.Configuration
{
    public class BangCapConfiguration : IEntityTypeConfiguration<BangCap>
    {
        public void Configure(EntityTypeBuilder<BangCap> builder)
        {
            builder.HasKey(p => p.MaBang);
        }
    }
}
