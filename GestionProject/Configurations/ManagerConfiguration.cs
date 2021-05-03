using GestionProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GestionProject.Configurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<AppUser>
    {
        private readonly string _managerId;
        public ManagerConfiguration()
        {
            _managerId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";
        }

        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var manager = new AppUser
            {
                Id = _managerId,
                UserName = "masteradmin",
                NormalizedUserName = "MASTERADMIN",
                Firstname = "Master",
                Lastname = "Admin",
                Email = "admin@gestionprojet.com",
                NormalizedEmail = "ADMIN@GESTIONPROJET.COM",
                PhoneNumber = "+212651728313",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
                Role = AppUserRoles.Manager,
            };
            manager.PasswordHash = GeneratePassword(manager);
            builder.HasData(manager);
        }

        public string GeneratePassword(AppUser user)
        {
            var passHash = new PasswordHasher<AppUser>();
            return passHash.HashPassword(user, "aDmin@gestprojet.com");
        }
    }
}

