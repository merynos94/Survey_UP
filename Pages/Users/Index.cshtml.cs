using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Models.Tables;

namespace SurveyUP.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


        public IList<ApplicationUser> AspNetUsers { get;set; }

        public async Task OnGetAsync()
        {
            AspNetUsers = await _userManager.Users.ToListAsync();
        }
    }
}
