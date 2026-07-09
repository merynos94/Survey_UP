using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Views.Answers
{
    public class DetailsModel : PageModel
    {
        private readonly N3mikosContext _context;

        public DetailsModel(N3mikosContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
