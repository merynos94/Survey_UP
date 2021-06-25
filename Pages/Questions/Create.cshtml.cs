using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Questions
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
            ViewData["SurveyId"] = new SelectList(_context.VtsTbSurvey, "SurveyId", "Title");
            return Page();
        }

        [BindProperty]
        public VtsTbQuestion VtsTbQuestion { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VtsTbQuestion.Add(VtsTbQuestion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
