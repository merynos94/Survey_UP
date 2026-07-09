using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SurveyUP.Pages.Voters
{
    public class SummaryModel : PageModel
    {
        private readonly N3mikosContext _context;

        public SummaryModel(N3mikosContext context)
        {
            _context = context;
        }

        public class AllAnswer
        {
            [Display(Name = "Tekst pytania")]
            public string QuestionText { get; set; }
            [Display(Name = "Teskt odpowiedzi")]
            public string AnswerText { get; set; }
            [Display(Name = "Id odpowiedzi")]
            public int AnswerId { get; set; }
            [Display(Name = "Ilość odpowiedzi")]
            public int AnswersCount { get; set; }
        }
        public List<AllAnswer> AllAnswers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

             AllAnswers = await  (from va in _context.VtsTbVoterAnswers
                          join v in _context.VtsTbVoter on va.VoterId equals v.VoterId
                          where v.SurveyId == id
                          group va by va.AnswerId into vg
                          select new AllAnswer
                          {

                              QuestionText = (from q in _context.VtsTbQuestion
                                              join a in _context.VtsTbAnswer on q.QuestionId equals a.QuestionId
                                              where a.AnswerId == vg.Key
                                              select q.QuestionText).FirstOrDefault(),
                              AnswerText = (from a in _context.VtsTbAnswer where a.AnswerId == vg.Key select a.AnswerText).FirstOrDefault(),
                              AnswerId = vg.Key,
                              AnswersCount = vg.Count()

                          }).ToListAsync();


            return Page();
        }
    }
}
