using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Surveys
{
    public class CreateModel : PageModel
    {
        private readonly N3mikosContext _context;

        public CreateModel(N3mikosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VtsTbSurvey VtsTbSurvey { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            

            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.VtsTbSurvey.Add(VtsTbSurvey);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
