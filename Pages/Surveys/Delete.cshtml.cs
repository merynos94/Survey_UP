using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Surveys
{
    public class DeleteModel : PageModel
    {
        private readonly N3mikosContext _context;

        public DeleteModel(N3mikosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VtsTbSurvey VtsTbSurvey { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbSurvey = await _context.VtsTbSurvey.FirstOrDefaultAsync(m => m.SurveyId == id);

            if (VtsTbSurvey == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbSurvey = await _context.VtsTbSurvey.FindAsync(id);

            if (VtsTbSurvey != null)
            {
                _context.VtsTbSurvey.Remove(VtsTbSurvey);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
