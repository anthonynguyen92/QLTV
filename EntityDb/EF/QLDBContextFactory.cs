using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EntityDb.EF
{
    public class QLDBContextFactory: IDesignTimeDbContextFactory<QLDBContext>
    {
        

        public QLDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("Appsettings.json").Build();

            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            var builder = new DbContextOptionsBuilder<QLDBContext>();
            builder.UseSqlServer(connectionstring);

            return new QLDBContext(builder.Options);
        }
    }
}
