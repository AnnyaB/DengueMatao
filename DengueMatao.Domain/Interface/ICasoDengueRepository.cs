using DengueMatao.Domain.Entities;

namespace DengueMatao.Domain.Interface
{
    public interface ICasoDengueRepository
    {
        //Assinaturas Customizadas.
        Task<IEnumerable<CasoDengue>> GetTodosCasosDengueAsync();
        Task<CasoDengue> GetByIdAsync(int? id);

        //Assinaturas de CRUD
        Task<CasoDengue> CreateAsync(CasoDengue casoDengue);
        Task<CasoDengue> UpdateAsync(CasoDengue casoDengue);
        Task<CasoDengue> RemoveAsync(CasoDengue casoDengue);
    }
}
