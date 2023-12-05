using DengueMatao.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DengueMatao.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CasoDengue> CasoDengue { get; set; }
        public DbSet<PessoaAfetada> PessoaAfetada { get; set; }

    }
}
