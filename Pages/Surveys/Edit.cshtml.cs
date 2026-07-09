using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Surveys
{
    public class EditModel : PageModel
    {
        private readonly N3mikosContext _context;

        public EditModel(N3mikosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VtsTbSurvey VtsTbSurvey { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbSurvey = await _context.VtsTbSurvey.FirstOrDefaultAsync(m => m.SurveyId == id);

            if (VtsTbSurvey == null)
            {
                return NotFound();
            }           
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

            VtsTbSurvey.CreationDate = DateTime.Now;
            _context.Attach(VtsTbSurvey).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VtsTbSurveyExists(VtsTbSurvey.SurveyId))
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

        private bool VtsTbSurveyExists(int id)
        {
            return _context.VtsTbSurvey.Any(e => e.SurveyId == id);
        }
    }
}
