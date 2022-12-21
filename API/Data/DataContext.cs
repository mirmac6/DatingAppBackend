using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<UserLike> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { Id = 1, UserName = "lisa", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 2, UserName = "karen", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 3, UserName = "margo", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 4, UserName = "lois", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 5, UserName = "ruthie", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 6, UserName = "todd", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 7, UserName = "porter", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 8, UserName = "mayo", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 9, UserName = "skinner", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key },
                new AppUser() { Id = 10, UserName = "david", PasswordHash = new HMACSHA512().ComputeHash(Encoding.UTF8.GetBytes("1234")), PasswordSalt = new HMACSHA512().Key }
            );
            modelBuilder.Entity<UserLike>()
                .HasKey(k => new { k.SourceUserId, k.TargetUserId });

            modelBuilder.Entity<UserLike>()
                .HasOne(s =>  s.SourceUser)
                .WithMany(l=>l.LikedUsers)
                .HasForeignKey(s=>s.SourceUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserLike>()
                .HasOne(s => s.TargetUser)
                .WithMany(l => l.LikedByUsers)
                .HasForeignKey(s => s.TargetUserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Message>()
                .HasOne(u => u.Recipient)
                .WithMany(m => m.MessageReceived)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(u => u.Sender)
                .WithMany(m => m.MessageSent)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
