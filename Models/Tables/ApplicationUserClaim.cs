using Microsoft.AspNetCore.Identity;

namespace SurveyUP.Models.Tables
{
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
