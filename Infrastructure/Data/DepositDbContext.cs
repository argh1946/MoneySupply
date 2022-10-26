using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DepositDbContext : DbContext
    {
        public DepositDbContext(DbContextOptions<DepositDbContext> options) : base(options) { }
        public DepositDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Branch>(
                    eb =>
                    {
                        eb.HasNoKey();
                        //eb.Property(v => v.Id).HasColumnName("ID");
                    });
        }

        public DbSet<Branch> Branch { get; set; }
    }
}