using Microsoft.AspNetCore.Identity;
using System;

namespace MVCEmployeeManager.Security
{
    public class AppIdentityUser : IdentityUser
    {
         public string FullName { get; set; }
         public DateTime BirthDate { get; set; }

       
    }
}
