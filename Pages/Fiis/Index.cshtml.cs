using Microsoft.AspNetCore.Mvc.RazorPages;
using FIIsAnalyzer.Data;
using FIIsAnalyzer.Models;
using Microsoft.EntityFrameworkCore;

namespace FIIsAnalyzer.Pages.FIIs
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<FII> ListaFIIs { get; set; }

        public async Task OnGetAsync()
        {
            ListaFIIs = await _context.FIIs.ToListAsync();
        }
    }
}