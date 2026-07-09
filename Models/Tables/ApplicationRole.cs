using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;

namespace SurveyUP.Models.Tables
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole() : base()
        {

        }
        public ApplicationRole(string role) : base(role) { }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
    }
}
