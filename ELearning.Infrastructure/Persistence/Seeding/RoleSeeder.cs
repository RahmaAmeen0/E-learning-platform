using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearning.Infrastructure.Persistence.Seeding
{
    public static class RoleSeeder
    {
        public static async Task seedAsync(RoleManager<IdentityRole<int>> roleManager)
        {
            string[] roles = ["Admin", "User", "Instructor"];

            foreach(var role in roles)
            {
                if(!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole<int>(role));
                }
            }
        }
    }
}
