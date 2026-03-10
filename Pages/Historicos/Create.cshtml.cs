using FIIsAnalyzer.Data;
using FIIsAnalyzer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FIIsAnalyzer.Pages.Historicos
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HistoricoCotacao Historico { get; set; }

        public List<FII> ListaFIIs { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            ListaFIIs = await _context.FIIs.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ListaFIIs = await _context.FIIs.ToListAsync(); // 🔧 ESSA LINHA É O QUE FALTAVA
                return Page();
            }

            _context.HistoricoCotacoes.Add(Historico);
            await _context.SaveChangesAsync();

            return RedirectToPage("/FIIs/Index");
        }
    }
}
