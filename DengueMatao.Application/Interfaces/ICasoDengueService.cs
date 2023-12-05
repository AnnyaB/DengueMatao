using DengueMatao.Application.DTOs;

namespace DengueMatao.Application.Interfaces
{
    public interface ICasoDengueService
    {
        Task<IEnumerable<CasoDengueDTO>> GetCasoDengue();
        Task<CasoDengueDTO> GetById(int id);
        Task Add(CasoDengueDTO casoDengueDTO);
        Task Update(CasoDengueDTO casoDengueDTO);
        Task Delete(int? id);
    }
}
