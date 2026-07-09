using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Views.Answers
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
            ViewData["AnswerTypeId"] = new SelectList(_context.VtsTbAnswerType, "AnswerTypeId", "Description");
            ViewData["QuestionId"] = new SelectList(_context.VtsTbQuestion, "QuestionId", "QuestionText");
                      
            return Page();
        }

        [BindProperty]
        public VtsTbAnswer Answer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VtsTbAnswer.Add(Answer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
