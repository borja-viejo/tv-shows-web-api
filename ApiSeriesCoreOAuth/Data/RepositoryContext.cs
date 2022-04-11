using ApiSeriesCoreOAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSeriesCoreOAuth.Data
{
    public class RepositoryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<Serie> Series { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
