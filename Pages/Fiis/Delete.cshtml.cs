using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FIIsAnalyzer.Data;
using FIIsAnalyzer.Models;

namespace FIIsAnalyzer.Pages.FIIs
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FII Fii { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Fii = await _context.FIIs.FindAsync(id);

            if (Fii == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var fii = await _context.FIIs.FindAsync(Fii.Id);

            if (fii == null)
                return NotFound();

            _context.FIIs.Remove(fii);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
