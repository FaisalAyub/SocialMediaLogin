using Abp.Authorization;
using BoilerPlaitApp.Authorization.Roles;
using BoilerPlaitApp.Authorization.Users;

namespace BoilerPlaitApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
