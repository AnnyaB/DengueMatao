namespace DengueMatao.Domain.Entities
{
    public sealed class PessoaAfetada
    {
        public int Id { get; set; }
        public int IdCasoDengue { get; set; }
        public string NomePessoa { get; set; }
        public int TempoSintomas { get; set; }
        public int QuantidadePessoas { get; set; }
        public string ExameImagem { get; set; }
    }
}
