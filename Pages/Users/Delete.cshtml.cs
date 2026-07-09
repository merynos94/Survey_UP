using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models.Tables;

namespace SurveyUP.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public DeleteModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
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


            if (AspNetUsers != null)
            {
                await _userManager.DeleteAsync(AspNetUsers);
            }

            return RedirectToPage("./Index");
        }
    }
}
