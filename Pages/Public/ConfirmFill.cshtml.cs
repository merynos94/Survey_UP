using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

using SurveyUP.Models.Tables;

namespace SurveyUP.Public
{
    [AllowAnonymous]
    public class ConfirmFill : PageModel
    {

        [BindProperty]
        public string ThanksData { get; set; }

        public async Task<IActionResult> OnGetAsync(string m)
        {
            if (m == null)
            {
                m = string.Empty;
            }

            ThanksData = m;

            return Page();
        }
    }
}
