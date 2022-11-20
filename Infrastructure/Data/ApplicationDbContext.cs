using Core.Contracts;
using Core.Entities;
using Core.Helper;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public ApplicationDbContext() { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
            //builder.ApplyConfiguration(new StatusCfg());
            var entitiesAssembly = typeof(BaseEntity).Assembly;
            builder.RegisterEntityTypeConfiguration(entitiesAssembly);
        }
        public DbSet<AtmCrs> AtmCrs { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<RequestStatus> RequestStatus { get; set; }
        //public DbSet<Status> Status { get; set; }
        public DbSet<MoneyType> MoneyType { get; set; }
        public DbSet<FileAttachment> FileAttachment { get; set; }
        public DbSet<FileType> FileType { get; set; }
    }
}