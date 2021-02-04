using Abp.Authorization;
using API_USER.Authorization.Roles;
using API_USER.Authorization.Users;

namespace API_USER.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
