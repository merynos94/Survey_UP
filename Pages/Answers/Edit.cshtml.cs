using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Views.Answers
{
    public class EditModel : PageModel
    {
        private readonly N3mikosContext _context;

        public EditModel(N3mikosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VtsTbAnswer VtsTbAnswer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbAnswer = await _context.VtsTbAnswer
                .Include(v => v.AnswerType)
                .Include(v => v.Question).FirstOrDefaultAsync(m => m.AnswerId == id);

            if (VtsTbAnswer == null)
            {
                return NotFound();
            }
           ViewData["AnswerTypeId"] = new SelectList(_context.VtsTbAnswerType, "AnswerTypeId", "Description");
           ViewData["QuestionId"] = new SelectList(_context.VtsTbQuestion, "QuestionId", "QuestionText");
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

            _context.Attach(VtsTbAnswer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VtsTbAnswerExists(VtsTbAnswer.AnswerId))
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

        private bool VtsTbAnswerExists(int id)
        {
            return _context.VtsTbAnswer.Any(e => e.AnswerId == id);
        }
    }
}
