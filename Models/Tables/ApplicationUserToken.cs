using Microsoft.AspNetCore.Identity;

namespace SurveyUP.Models.Tables
{
    public class ApplicationUserToken : IdentityUserToken<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
