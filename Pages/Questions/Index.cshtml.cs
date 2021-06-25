using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Questions
{
    public class IndexModel : PageModel
    {
        private readonly N3mikosContext _context;

        public IndexModel(N3mikosContext context)
        {
            _context = context;
        }

        public IList<VtsTbQuestion> VtsTbQuestion { get;set; }
        //public IList<VtsTbQuestion> VtsTbSurvey { get; set; }
        public async Task OnGetAsync()
        {
            VtsTbQuestion = await _context.VtsTbQuestion
                .Include(v => v.Survey).ToListAsync();
        }
    }
}
