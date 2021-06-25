using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Questions
{
    public class DetailsModel : PageModel
    {
        private readonly N3mikosContext _context;

        public DetailsModel(N3mikosContext context)
        {
            _context = context;
        }

        public VtsTbQuestion VtsTbQuestion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbQuestion = await _context.VtsTbQuestion
                .Include(v => v.Survey).FirstOrDefaultAsync(m => m.QuestionId == id);

            if (VtsTbQuestion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
