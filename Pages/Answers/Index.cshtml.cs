using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Views.Answers
{
    public class IndexModel : PageModel
    {
        private readonly N3mikosContext _context;

        public IndexModel(N3mikosContext context)
        {
            _context = context;
        }

        public IList<VtsTbAnswer> VtsTbAnswer { get;set; }

        public async Task OnGetAsync()
        {
            VtsTbAnswer = await _context.VtsTbAnswer
                .Include(v => v.AnswerType)
                .Include(v => v.Question).ToListAsync();
        }
    }
}
