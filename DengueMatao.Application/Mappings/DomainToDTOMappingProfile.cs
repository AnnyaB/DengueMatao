using AutoMapper;
using DengueMatao.Application.DTOs;
using DengueMatao.Domain.Entities;

namespace DengueMatao.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
           

            CreateMap<PessoaAfetada, PessoaAfetadaDTO>().ReverseMap();
            CreateMap<CasoDengue, CasoDengueDTO>().ReverseMap();
            
        }
    }
}
