using Microsoft.AspNetCore.Identity;

namespace MVCEmployeeManager.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }

    }
}
