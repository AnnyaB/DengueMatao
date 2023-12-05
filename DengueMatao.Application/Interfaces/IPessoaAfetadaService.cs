using DengueMatao.Application.DTOs;

namespace DengueMatao.Application.Interfaces
{
    public interface IPessoaAfetadaService
    {
        Task<IEnumerable<PessoaAfetadaDTO>> GetPessoaAfetada();
        Task<PessoaAfetadaDTO> GetById(int id);
        Task Add(PessoaAfetadaDTO pessoaAfetadaDTO);
        Task Update(PessoaAfetadaDTO pessoaAfetadaDTO);
        Task Delete(int? id);
    }
}
