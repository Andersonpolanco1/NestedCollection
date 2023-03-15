using Microsoft.EntityFrameworkCore;
using PruebaAyu.Models;

namespace PruebaAyu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<TipoAnexo> TipoAnexo { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<Anexo> Anexos { get; set; }
    }
}
