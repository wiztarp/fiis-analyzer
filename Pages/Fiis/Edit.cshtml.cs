using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FIIsAnalyzer.Data;
using FIIsAnalyzer.Models;

namespace FIIsAnalyzer.Pages.FIIs
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FII FiiEditado { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            FiiEditado = await _context.FIIs.FindAsync(id);

            if (FiiEditado == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var fiiOriginal = await _context.FIIs.FindAsync(FiiEditado.Id);

            if (fiiOriginal == null)
            {
                return NotFound();
            }

            // Atualiza manualmente os campos
            fiiOriginal.Codigo = FiiEditado.Codigo;
            fiiOriginal.Setor = FiiEditado.Setor;
            fiiOriginal.Descricao = FiiEditado.Descricao;
            fiiOriginal.Quantidade = FiiEditado.Quantidade;
            fiiOriginal.CotacaoAtual = FiiEditado.CotacaoAtual;

            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
