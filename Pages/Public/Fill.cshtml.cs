using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SurveyUP.Data;
using SurveyUP.Models;
using SurveyUP.Models.Tables;
using SurveyUP.Tables;


namespace SurveyUP.Pages.Public
{
    public class FillModel : PageModel
    {
        private readonly N3mikosContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public List<QuestionToFill> QuestionsToFill { get; set; }
        public string SurveyName { get; set; }


        public class QuestionToFill
        {
            public int QuestionId { get; set; }
            [Display(Name = "Tekst pytania")]
            public string QuestionText { get; set; }
            [Display(Name = "Pozycja pytania")]
            public int? DisplayOrder { get; set; }
            public string QuestionIdText { get; set; }
            public string HelpText { get; set; }
            public string Alias { get; set; }
            public List<VtsTbAnswer> Answers { get; set; }
        }

        public FillModel(
            UserManager<ApplicationUser> userManager,
            N3mikosContext context)
        {
            _context = context;
            _userManager = userManager;
        }



        public IActionResult OnGet(int? id)
        {

            TempData["SurveyId"] = id;

            TempData["DateStart"] = DateTime.Now.ToString();

            var survey = (from s in _context.VtsTbSurvey
                          where s.SurveyId == id 
                          select s).FirstOrDefault();

            SurveyName = survey.Title;
            TempData["ThanksData"] = survey.ThankYouMessage ?? "Dziękuje";

            QuestionsToFill = (from q in _context.VtsTbQuestion
                               orderby q.DisplayOrder, q.QuestionId
                               where q.SurveyId == id                                
                               select new QuestionToFill
                               {
                                   QuestionId = q.QuestionId,
                                   QuestionText = q.QuestionText,
                                   DisplayOrder = q.DisplayOrder,
                                   HelpText = q.HelpText,
                                   Alias = q.Alias,
                                   Answers = (from a in _context.VtsTbAnswer
                                              orderby a.DisplayOrder
                                              where a.QuestionId == q.QuestionId
                                              select a).ToList()
                               }).ToList();

            QuestionsToFill = QuestionsToFill.OrderBy(q => q.DisplayOrder).ToList();


            return Page();
        }



        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            var userId = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;

            var voter = new VtsTbVoter
            {
                Uid = userId,
                SurveyId = Convert.ToInt32(TempData["SurveyId"]),
                StartDate = Convert.ToDateTime(TempData["DateStart"]),
                Validated = false,
                Ipsource = this.HttpContext.Connection.RemoteIpAddress.ToString()
            };
            await _context.AddAsync<VtsTbVoter>(voter);
            await _context.SaveChangesAsync();

            foreach (var k in Request.Form)
            {
                if (!k.Key.Equals("__RequestVerificationToken"))
                {

                    var answer = k.Value.ToArray();
                    var answerLength = answer.Length;
                    int answerId = 0;
                    var answerText = string.Empty;


                    if (answerLength > 1)
                    {
                        if (Int32.TryParse(answer[0], out answerId))
                        {
                            if (answerLength > 1)
                            {
                                for (int i = 1; i < answerLength; i++)
                                {
                                    answerText += answer[i];
                                    if (i < answerLength) answerText += "|";
                                }
                            }
                        }
                        else
                        {
                            _ = Int32.TryParse(k.Key, out answerId);
                            answerText = string.Join('|', answer);
                        }
                    }
                    else
                    {
                        if (Int32.TryParse(k.Value, out answerId))
                        {
                            answerText = "checked";
                        }
                        else
                        {
                            _ = Int32.TryParse(k.Key, out answerId);
                            answerText = k.Value;
                        }

                    }

                    var voterAnswer = new VtsTbVoterAnswers
                    {
                        Voter = voter,
                        AnswerId = answerId,
                        AnswerText = answerText
                    };
                    await _context.AddAsync<VtsTbVoterAnswers>(voterAnswer);
                    await _context.SaveChangesAsync();
                }

            }

            

            return RedirectToPage("./ConfirmFill", new { m = TempData["ThanksData"].ToString() });
        }


    }
}

