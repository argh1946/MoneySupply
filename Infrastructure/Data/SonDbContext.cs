using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SonDbContext : DbContext
    {


        public SonDbContext(DbContextOptions<SonDbContext> options) : base(options) { }
        public SonDbContext() { }



        public DbSet<User> User { get; set; }



    }
}
