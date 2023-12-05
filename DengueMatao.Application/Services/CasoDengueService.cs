using AutoMapper;
using DengueMatao.Application.DTOs;
using DengueMatao.Application.Interfaces;
using DengueMatao.Domain.Entities;
using DengueMatao.Domain.Interface;

namespace DengueMatao.Application.Services
{
    public class CasoDengueService : ICasoDengueService
    {
        private ICasoDengueRepository _casoDengueRepository;
        private readonly IMapper _mapper;

        public CasoDengueService(ICasoDengueRepository casoDengueRepository, IMapper mapper)
        {
            _casoDengueRepository = casoDengueRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CasoDengueDTO>> GetCasoDengue()
        {
            var casoDengueEntity = await _casoDengueRepository.GetTodosCasosDengueAsync();
            return _mapper.Map<IEnumerable<CasoDengueDTO>>(casoDengueEntity);
        }

        public async Task<CasoDengueDTO> GetById(int id)
        {
            var casoDengueEntity = await _casoDengueRepository.GetByIdAsync(id);
            return _mapper.Map<CasoDengueDTO>(casoDengueEntity);
        }

        public async Task Add(CasoDengueDTO casoDengueDTO)
        {
            var casoDengueEntity = _mapper.Map<CasoDengue>(casoDengueDTO);
            await _casoDengueRepository.CreateAsync(casoDengueEntity);
        }

        public async Task Update(CasoDengueDTO casoDengueDTO)
        {
            var casoDengueEntity = _mapper.Map<CasoDengue>(casoDengueDTO);
            await _casoDengueRepository.UpdateAsync(casoDengueEntity);
        }

        public async Task Delete(int? id)
        {
            var casoDengueEntity = _casoDengueRepository.GetByIdAsync(id).Result;
            await _casoDengueRepository.RemoveAsync(casoDengueEntity);
        }
    }
}
