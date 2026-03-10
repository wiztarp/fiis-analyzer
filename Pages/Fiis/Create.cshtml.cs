using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FIIsAnalyzer.Data;
using FIIsAnalyzer.Models;

namespace FIIsAnalyzer.Pages.FIIs
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FII NovoFII { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Volta pro formulário com erro
            }

            _context.FIIs.Add(NovoFII);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
