using BLL.Services.GenericService;
using BLL.Services.UserIdentityManagement.Interfaces;
using Core.Models;
using DAL.Repository.Interface;

namespace BLL.Services.UserIdentityManagement
{
    public class UserIdentityService : GenericService<UserIdentity>, IUserIdentityService
    {
        public UserIdentityService(IRepository<UserIdentity> repository) : base(repository) { }
    }
}