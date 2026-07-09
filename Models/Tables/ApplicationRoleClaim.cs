using Microsoft.AspNetCore.Identity;

namespace SurveyUP.Models.Tables
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>
    {
        public virtual ApplicationRole Role { get; set; }
    }
}
