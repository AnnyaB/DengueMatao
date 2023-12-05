using DengueMatao.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DengueMatao.Application.DTOs
{
    public class PessoaAfetadaDTO
    {
        public int Id { get; set; }
        public int IdCasoDengue { get; set; }
        public string NomePessoa { get; set; }
        public int TempoSintomas { get; set; }
        public int QuantidadePessoas { get; set; }
        public string ExameImagem { get; set; }


    }
}
