using Microsoft.EntityFrameworkCore;

namespace Tasks.Infra.Data.Contexts
{
    public class AppContext : DbContext
    {
        private readonly ConnectionString _connectionString;

        public AppContext(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_connectionString.Tasks);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
