using System;
using System.Collections.Generic;
using System.Text;
using ELearning.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace ELearning.Infrastructure.Persistence.Seeding
{
    public static class AdminSeeder
    {
        public static async Task seedAsync(UserManager<User> userManager)
        {
            string adminEmail = "admin123@gmail.com";
            string password = "123ElearningAdmin";

            var admin = await userManager.FindByEmailAsync(adminEmail);

            if(admin == null)
            {
                admin = new User
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(admin, password); 
            }

            if(! await userManager.IsInRoleAsync(admin, "Admin"))
            {
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }
    }
}
