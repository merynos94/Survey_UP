using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Voters
{
    public class EditModel : PageModel
    {
        private readonly N3mikosContext _context;

        public EditModel(N3mikosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VtsTbVoter VtsTbVoter { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbVoter = await _context.VtsTbVoter.FirstOrDefaultAsync(m => m.VoterId == id);

            if (VtsTbVoter == null)
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

            _context.Attach(VtsTbVoter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VtsTbVoterExists(VtsTbVoter.VoterId))
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

        private bool VtsTbVoterExists(int id)
        {
            return _context.VtsTbVoter.Any(e => e.VoterId == id);
        }
    }
}
