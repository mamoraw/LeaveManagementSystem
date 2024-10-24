using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "e5c42c59-ea07-425e-b154-d44718dbc035",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "eef81ed0-c8f0-4e2d-b91e-ab601be06dbb",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole
                {
                    Id = "1ba60648-1989-4c5c-8fae-dc3199c78cba",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "3b0ca64d-f877-4dd5-8944-edf7551a967e",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                    FirstName = "Default",
                    LastName = "Admin",
                    DateOfBirth = new DateOnly(1950,12,01)
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1ba60648-1989-4c5c-8fae-dc3199c78cba",
                    UserId = "3b0ca64d-f877-4dd5-8944-edf7551a967e"
                });

        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
