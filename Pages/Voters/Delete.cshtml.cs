using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SurveyUP.Models;
using SurveyUP.Tables;

namespace SurveyUP.Pages.Voters
{
    public class DeleteModel : PageModel
    {
        private readonly N3mikosContext _context;

        public DeleteModel(N3mikosContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VtsTbVoter = await _context.VtsTbVoter.FindAsync(id);

            if (VtsTbVoter != null)
            {
                _context.VtsTbVoter.Remove(VtsTbVoter);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
