using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { Id = 1, UserName = "Pera" },
                new AppUser() { Id = 2, UserName = "Mika" },
                new AppUser() { Id = 3, UserName = "Ana" }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
