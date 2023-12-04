using DengueMatao.Domain.Interface;

namespace DengueMatao.Domain.Entities
{
    public sealed class CasoDengue
    {
        public int Id { get; private set; }
        public string Cep { get; private set; }
        public string NomeRua { get; private set; }
        public string Bairro { get; private set; }
        public int NumeroCasa { get; private set; }
        public DateTime DataRegistro { get; private set; }

        public CasoDengue TodosCasosDengue { get; set; }
    }
}
