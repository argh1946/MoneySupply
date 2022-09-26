using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public ApplicationDbContext() { }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);                   

        //    builder.Entity<Request>()
        //    .HasOne(i => i.RequestStatus)
        //    .WithMany()
        //    .OnDelete(DeleteBehavior.Restrict);
        //}

        public DbSet<AtmCrs> AtmCrs { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<RequestStatus> RequestStatus { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<MoneyType> MoneyType { get; set; }


    }
}
