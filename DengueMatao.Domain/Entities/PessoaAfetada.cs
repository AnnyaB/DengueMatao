namespace DengueMatao.Domain.Entities
{
    public sealed class PessoaAfetada
    {
        public int Id { get; private set; }
        public int IdCasoDengue { get; private set; }
        public string NomePessoa { get; private set; }
        public int TempoSintomas { get; private set; }
        public int QuantidadePessoas { get; private set; }
        public string ExameImagem { get; private set; }

        public PessoaAfetada TodasPessoasAfetadas { get; set; }
        public CasoDengue CasoDengue { get; set; }
    }
}
