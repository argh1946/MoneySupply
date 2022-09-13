using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public ApplicationDbContext() { }

        public DbSet<AtmCrs> AtmCrs { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<RequestStatus> RequestStatus { get; set; }
        public DbSet<Status> Status { get; set; }

    }
}
