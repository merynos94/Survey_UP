using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SurveyUP.Models;
using System.ComponentModel.DataAnnotations;
using SurveyUP.Models.Tables;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SurveyUP.Pages.Roles
{
    public class DetailsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public record RoleDetails
        {
            [Display(Name = "Nazwa")]
            public string Name { get; set; }
            [Display(Name = "Użytkownicy")]
            public IList<ApplicationUser> Users { get; set; }
        }

        private readonly N3mikosContext _context;

        public DetailsModel(
            N3mikosContext context,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public RoleDetails AspNetRole { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AspNetRole = new RoleDetails
            {
                Name = id
            };
            AspNetRole.Users = await _userManager.GetUsersInRoleAsync(id);

            if (AspNetRole == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
