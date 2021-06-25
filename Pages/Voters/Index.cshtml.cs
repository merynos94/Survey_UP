using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using System.ComponentModel.DataAnnotations;

namespace SurveyUP.Pages.Voters
{
    public class IndexModel : PageModel
    {
        private readonly N3mikosContext _context;

        public IndexModel(N3mikosContext context)
        {
            _context = context;
        }

        public class LocalVotes  
        {
            [Display(Name = "Tytuł ankiety")]
            public string SurveyTitle { get; set; }
            [Display(Name = "Ilość głosów")]
            public int SurveyCount { get; set; }
            [Display(Name = "ID ankiety")]
            public int? SurveyId { get; set; }
        }

        public IList<LocalVotes> Votes { get;set; }

        public async Task OnGetAsync()
        {

            Votes = await (from v in _context.VtsTbVoter
                            join s in _context.VtsTbSurvey
                            on v.SurveyId equals s.SurveyId into j1
                            from j2 in j1.DefaultIfEmpty()
                            group j2 by v.SurveyId into g
                            select new LocalVotes
                            {
                                SurveyTitle = (from s in _context.VtsTbSurvey
                                               where s.SurveyId == g.Key
                                               select s.Title).FirstOrDefault(),
                                SurveyId = g.Key,
                                SurveyCount = g.Count()
                            }).ToListAsync();
        }
    }
}
