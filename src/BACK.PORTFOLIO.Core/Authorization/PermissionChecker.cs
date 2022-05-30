using Abp.Authorization;
using BACK.PORTFOLIO.Authorization.Roles;
using BACK.PORTFOLIO.Authorization.Users;

namespace BACK.PORTFOLIO.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
