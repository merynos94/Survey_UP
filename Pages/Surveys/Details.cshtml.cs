using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SurveyUP.Models;
using SurveyUP.Tables;
using System.ComponentModel.DataAnnotations;

namespace SurveyUP.Pages.Surveys
{
    public class DetailsModel : PageModel
    {
        private readonly N3mikosContext _context;

        public DetailsModel(N3mikosContext context)
        {
            _context = context;
        }

        public VtsTbSurvey VtsTbSurvey { get; set; }
        
        [Display(Name = "Liczba głosujących")]
        public int VoterNumber { get; set; }
        [Display(Name = "Liczba stron ankiety")]
        public int? TotalPageNumber { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbSurvey = await _context.VtsTbSurvey.FirstOrDefaultAsync(m => m.SurveyId == id);

            VoterNumber = await _context.VtsTbVoter.CountAsync(v => !v.Validated.Value && v.SurveyId.Value == id);


            TotalPageNumber = (from q in _context.VtsTbQuestion where q.SurveyId == id
                               where q.SurveyId != null
                               select _context.VtsTbQuestion.Max(t => t.PageNumber)).FirstOrDefault();


            if (VtsTbSurvey == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
