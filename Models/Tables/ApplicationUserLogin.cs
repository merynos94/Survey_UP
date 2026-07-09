using Microsoft.AspNetCore.Identity;

namespace SurveyUP.Models.Tables
{
    public class ApplicationUserLogin : IdentityUserLogin<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
