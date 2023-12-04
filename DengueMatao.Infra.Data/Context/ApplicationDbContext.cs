using DengueMatao.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DengueMatao.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CasoDengue> TodosCasosDengue { get; set; }
        public DbSet<PessoaAfetada> TodasPessoasAfetadas { get; set; }

    }
}
