using DengueMatao.Domain.Entities;
using DengueMatao.Domain.Interface;
using DengueMatao.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DengueMatao.Infra.Data.Repositories
{
    public class CasoDengueRepository : ICasoDengueRepository
    {
        ApplicationDbContext _casoDengueContext;

        public CasoDengueRepository(ApplicationDbContext context)
        {
            _casoDengueContext = context;
        }

        public async Task<IEnumerable<CasoDengue>> GetTodosCasosDengueAsync()
        {
            return await _casoDengueContext.TodosCasosDengue.ToListAsync();
        }

        public async Task<CasoDengue> CreateAsync(CasoDengue casoDengue)
        {
            _casoDengueContext.Add(casoDengue);
            await _casoDengueContext.SaveChangesAsync();
            return casoDengue;
        }

        public async Task<CasoDengue> GetByIdAsync(int? id)
        {
            return await _casoDengueContext.TodosCasosDengue.FindAsync(id);
        }

        public async Task<CasoDengue> RemoveAsync(CasoDengue casoDengue)
        {
            _casoDengueContext.Remove(casoDengue);
            await _casoDengueContext.SaveChangesAsync();
            return casoDengue;
        }

        public async Task<CasoDengue> UpdateAsync(CasoDengue casoDengue)
        {
            _casoDengueContext.Update(casoDengue);
            await _casoDengueContext.SaveChangesAsync();
            return casoDengue;
        }
    }
}
