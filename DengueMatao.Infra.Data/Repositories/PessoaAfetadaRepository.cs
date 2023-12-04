using DengueMatao.Domain.Entities;
using DengueMatao.Domain.Interface;
using DengueMatao.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DengueMatao.Infra.Data.Repositories
{
    public class PessoaAfetadaRepository : IPessoaAfetadaRepository
    {
        ApplicationDbContext _pessoaAfetadaContext;
        public PessoaAfetadaRepository(ApplicationDbContext context)
        {
            _pessoaAfetadaContext = context;
        }

        public async Task<IEnumerable<PessoaAfetada>> GetTodasPessoasAfetadasAsync()
        {
            return await _pessoaAfetadaContext.TodasPessoasAfetadas.ToListAsync();
        }

        public async Task<PessoaAfetada> CreateAsync(PessoaAfetada pessoaAfetada)
        {
            _pessoaAfetadaContext.Add(pessoaAfetada);
            await _pessoaAfetadaContext.SaveChangesAsync();
            return pessoaAfetada;
        }

        public async Task<PessoaAfetada> GetByIdAsync(int? id)
        {
            return await _pessoaAfetadaContext.TodasPessoasAfetadas.FindAsync(id);
        }

        public async Task<PessoaAfetada> RemoveAsync(PessoaAfetada pessoaAfetada)
        {
            _pessoaAfetadaContext.Remove(pessoaAfetada);
            await _pessoaAfetadaContext.SaveChangesAsync();
            return pessoaAfetada;
        }

        public async Task<PessoaAfetada> UpdateAsync(PessoaAfetada pessoaAfetada)
        {
            _pessoaAfetadaContext.Update(pessoaAfetada);
            await _pessoaAfetadaContext.SaveChangesAsync();
            return pessoaAfetada;
        }
    }
}
