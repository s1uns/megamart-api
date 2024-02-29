using megamart_api.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DAL.BuildExtensions
{
    public static class ContextExtension
    {
        public static void AddDbSetup(this IServiceCollection services,
           IConfiguration configuration)
        {
            string connection = configuration.GetConnectionString("MySql") ?? string.Empty;
            services.AddDbContext<MegamartContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<MegamartContext>();
        }
    }
}