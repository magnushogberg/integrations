using Microsoft.EntityFrameworkCore;

namespace If.Itc.Integrations.Web.Context
{
    public class IntegrationsDbContext : DbContext
    {
        public IntegrationsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Integration> Integrations { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Environment> Environments { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<SubIntegration> SubIntegrations { get; set; }

    }
}
