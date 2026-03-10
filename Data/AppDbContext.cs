using FIIsAnalyzer.Models;
using Microsoft.EntityFrameworkCore;

namespace FIIsAnalyzer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<FII> FIIs { get; set; }
        public DbSet<Dividendo> Dividendos { get; set; }
        public DbSet<HistoricoCotacao> HistoricoCotacoes { get; set; }

    }
}
