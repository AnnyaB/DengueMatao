using DengueMatao.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DengueMatao.Application.DTOs
{
    public class CasoDengueDTO
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string NomeRua { get; set; }
        public string Bairro { get; set; }
        public int NumeroCasa { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
