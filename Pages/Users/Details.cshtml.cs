using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Models.Tables;

namespace SurveyUP.Pages.Users
{
    public class DetailsModel : PageModel
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public DetailsModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public ApplicationUser AspNetUsers { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AspNetUsers = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (AspNetUsers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
