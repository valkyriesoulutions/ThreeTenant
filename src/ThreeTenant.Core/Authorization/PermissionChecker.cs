using Abp.Authorization;
using ThreeTenant.Authorization.Roles;
using ThreeTenant.Authorization.Users;

namespace ThreeTenant.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
