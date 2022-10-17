using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public ApplicationDbContext() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Status>().HasData
           (
               new Status { Id = 1, Title = "تایید نماینده پول رسان" },
               new Status { Id = 2, Title = "تایید ارتباط فردا" },
               new Status { Id = 3, Title = "تایید مدیر گروه خزانه" },
               new Status { Id = 4, Title = "تایید حسابدار خزانه" },
               new Status { Id = 5, Title = "تایید اداره عملیات" },
               new Status { Id = 6, Title = "تایید معاون گروه خزانه - تسویه" },
               new Status { Id = 7, Title = "تایید پول رسان - تسویه" },
               new Status { Id = 8, Title = "تایید مدیر گروه خزانه - تسویه" },
               new Status { Id = 9, Title = "تایید حسابدار خزانه - تسویه" },
               new Status { Id = 10, Title = "تایید اداره عملیات - تسویه" },
               new Status { Id = 11, Title = "رد نماینده پول رسان" },
               new Status { Id = 12, Title = "رد ارتباط فردا" },
               new Status { Id = 13, Title = "رد مدیر گروه خزانه" },
               new Status { Id = 14, Title = "رد حسابدار خزانه" },
               new Status { Id = 15, Title = "رد اداره عملیات" },
               new Status { Id = 16, Title = "رد معاون گروه خزانه - تسویه" },
               new Status { Id = 17, Title = "رد پول رسان - تسویه" },
               new Status { Id = 18, Title = "رد مدیر گروه خزانه - تسویه" },
               new Status { Id = 19, Title = "رد حسابدار خزانه - تسویه" },
               new Status { Id = 20, Title = "رد اداره عملیات - تسویه" }
           );
        }

        public DbSet<AtmCrs> AtmCrs { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<RequestStatus> RequestStatus { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<MoneyType> MoneyType { get; set; }
        public DbSet<FileAttachment> FileAttachment { get; set; }


    }
}
