using BLL.Services.CategoryManager.Interfaces;
using BLL.Services.CategoryManager;
/*using BLL.Services.GenericService.Interfaces;
using BLL.Services.GenericService;*/
using DAL.Repository.Interface;
using DAL.Repository;
using BLL.Services.GoodManagement.Interfaces;
using BLL.Services.GoodManagement;
using BLL.Services.IdentityManagement.Interfaces;
using BLL.Services.IdentityManagement;
using BLL.Services.ProfileManagement.Interface;
using BLL.Services.ProfileManagement;

namespace megamart_api.BuildExtensions
{
    internal static class ServicesInjection
    {
        internal static void AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ITokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IGoodService, GoodService>();
        }
    }
}
