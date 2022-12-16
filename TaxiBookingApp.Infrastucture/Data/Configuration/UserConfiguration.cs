﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaxiBookingApp.Infrastucture.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
               .Property(p => p.IsActive)
               .HasDefaultValue(true);

            builder.HasData(CreateUser());
        }
        private List<ApplicationUser> CreateUser()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "dea1286-c198-4129-b3f3-b89d839582",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com",
                
            };
            user.PasswordHash =
                hasher.HashPassword(user, "agent123");
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
            };
            user.PasswordHash =
                hasher.HashPassword(user, "guest123");

            users.Add(user);

            return users;
        }

    }
}