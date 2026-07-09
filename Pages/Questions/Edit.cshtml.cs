using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Questions
{
    public class EditModel : PageModel
    {
        private readonly N3mikosContext _context;

        public EditModel(N3mikosContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["SurveyId"] = new SelectList(_context.VtsTbSurvey, "SurveyId", "Title");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VtsTbQuestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VtsTbQuestionExists(VtsTbQuestion.QuestionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VtsTbQuestionExists(int id)
        {
            return _context.VtsTbQuestion.Any(e => e.QuestionId == id);
        }
    }
}
