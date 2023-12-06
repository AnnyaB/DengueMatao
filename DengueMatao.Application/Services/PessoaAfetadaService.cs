using AutoMapper;
using DengueMatao.Application.DTOs;
using DengueMatao.Application.Interfaces;
using DengueMatao.Domain.Entities;
using DengueMatao.Domain.Interface;

namespace DengueMatao.Application.Services
{
    public class PessoaAfetadaService : IPessoaAfetadaService
    {
        private IPessoaAfetadaRepository _pessoaAfetadaRepository;
        private readonly IMapper _mapper;

        public PessoaAfetadaService(IPessoaAfetadaRepository pessoaAfetadaRepository, IMapper mapper)
        {
            _pessoaAfetadaRepository = pessoaAfetadaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PessoaAfetadaDTO>> GetPessoaAfetada()
        {
            var pessoaAfetadaEntity = await _pessoaAfetadaRepository.GetTodasPessoasAfetadasAsync();
            return _mapper.Map<IEnumerable<PessoaAfetadaDTO>>(pessoaAfetadaEntity);
        }

        public async Task<PessoaAfetadaDTO> GetById(int id)
        {
            var pessoaAfetadaEntity = await _pessoaAfetadaRepository.GetByIdAsync(id);
            return _mapper.Map<PessoaAfetadaDTO>(pessoaAfetadaEntity);
        }

        public async Task Add(PessoaAfetadaDTO pessoaAfetadaDTO)
        {
            var pessoaAfetadaEntity = _mapper.Map<PessoaAfetada>(pessoaAfetadaDTO);
            await _pessoaAfetadaRepository.CreateAsync(pessoaAfetadaEntity);
        }

        public async Task Update(PessoaAfetadaDTO pessoaAfetadaDTO)
        {
            var pessoaAfetadaEntity = _mapper.Map<PessoaAfetada>(pessoaAfetadaDTO);
            await _pessoaAfetadaRepository.UpdateAsync(pessoaAfetadaEntity);
        }

        public async Task Delete(int? id)
        {
            var pessoaAfetadaEntity = await _pessoaAfetadaRepository.GetByIdAsync(id);
            await _pessoaAfetadaRepository.RemoveAsync(pessoaAfetadaEntity);
        }
    }
}
