using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AirsoftShop.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Replica> Replicas { get; set; }

        public DbSet<Part> Parts { get; set; }

        public DbSet<Accessory> Accessories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Complaint> Complaints { get; set; }

        public DbSet<PostWarranty> PostWarranties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Replica)
                .WithMany()
                .HasForeignKey(o => o.ReplicaId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Part)
                .WithMany()
                .HasForeignKey(o => o.PartId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Accessory)
                .WithMany()
                .HasForeignKey(o => o.AccessoryId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Complaint>()
                .HasMany(c => c.ComplaintItems)
                .WithOne(ci => ci.Complaint)
                .HasForeignKey(ci => ci.ComplaintId)
                .OnDelete(DeleteBehavior.Cascade);

            var password = new PasswordHasher<ApplicationUser>();
            var hashed = password.HashPassword(new ApplicationUser(), "Admin1!");

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser() { Id = "1", UserName = "admin1", NormalizedUserName = "ADMIN1", PasswordHash = hashed, EmailConfirmed = true, Email = "admin@gmail.com", NormalizedEmail = "ADMIN@GMAIL.COM", LockoutEnabled = true },
                new ApplicationUser() { Id = "2", UserName = "user1", NormalizedUserName = "USER1", PasswordHash = hashed, EmailConfirmed = true, Email = "user@gmail.com", NormalizedEmail = "USER@GMAIL.COM", LockoutEnabled = true },
                new ApplicationUser() { Id = "3", UserName = "user2", NormalizedUserName = "USER2", PasswordHash = hashed, EmailConfirmed = true, Email = "user2@gmail.com", NormalizedEmail = "USER2@GMAIL.COM", LockoutEnabled = true },
                new ApplicationUser() { Id = "4", UserName = "user3", NormalizedUserName = "USER3", PasswordHash = hashed, EmailConfirmed = true, Email = "user3@gmail.com", NormalizedEmail = "USER3@GMAIL.COM", LockoutEnabled = true }
                );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole() { Id = "2", Name = "User", NormalizedName = "USER" }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" },
                new IdentityUserRole<string> { UserId = "2", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "3", RoleId = "2" },
                new IdentityUserRole<string> { UserId = "4", RoleId = "2" }
                );
        }
    }
}
