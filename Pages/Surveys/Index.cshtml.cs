using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Surveys
{
    public class IndexModel : PageModel
    {
        private readonly N3mikosContext _context;

        public IndexModel(N3mikosContext context)
        {
            _context = context;
        }

        public IList<VtsTbSurvey> VtsTbSurvey { get;set; }

        public async Task OnGetAsync()
        {
            VtsTbSurvey = await _context.VtsTbSurvey.ToListAsync();
        }
    }
}
