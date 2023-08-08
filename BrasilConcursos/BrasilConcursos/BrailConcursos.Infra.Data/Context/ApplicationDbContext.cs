using BrasilConcursos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BrasilConcursos.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Concourse> concourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concourse>()
                .Property(x => x.CreatedAt)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Concourse>()
                .Property(x => x.UpdatedAt)
                .HasDefaultValueSql("getdate()");
        }
    }
}
