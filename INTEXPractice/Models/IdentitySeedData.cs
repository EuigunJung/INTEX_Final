using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXPractice.Models
{
    public class IdentitySeedData
    {
        // TODO: Remove idenity seed data
        //create constants for username and password for the admin user
        private const string adminUser = "Admin";
        private const string adminPassword = "ExtraYeetPeriod";

        //method to check for user info in database and seed it with admin login info if not
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            IdentityDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<IdentityDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user = await userManager.FindByIdAsync(adminUser);

            if (user == null)
            {
                user = new IdentityUser(adminUser);

                user.Email = "admin@yeet.com";
                user.PhoneNumber = "555-1234";

                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
