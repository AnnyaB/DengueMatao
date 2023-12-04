using DengueMatao.Domain.Entities;

namespace DengueMatao.Domain.Interface
{
    public interface IPessoaAfetadaRepository
    {
        //Assinaturas Customizadas.
        Task<IEnumerable<PessoaAfetada>> GetTodasPessoasAfetadasAsync();
        Task<PessoaAfetada> GetByIdAsync(int? id);

        //Assinaturas de CRUD
        Task<PessoaAfetada> CreateAsync(PessoaAfetada pessoasAfetada);
        Task<PessoaAfetada> UpdateAsync(PessoaAfetada pessoasAfetada);
        Task<PessoaAfetada> RemoveAsync(PessoaAfetada pessoasAfetada);
    }
}
