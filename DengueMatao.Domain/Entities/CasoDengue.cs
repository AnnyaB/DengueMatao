using DengueMatao.Domain.Interface;

namespace DengueMatao.Domain.Entities
{
    public sealed class CasoDengue
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string NomeRua { get; set; }
        public string Bairro { get; set; }
        public int NumeroCasa { get; set; }
        public DateTime DataRegistro { get; set; }

    }
}
