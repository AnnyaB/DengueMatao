using DengueMatao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DengueMatao.Infra.Data.EntityConfiguration
{
    public class PessoaAfetadaConfiguration : IEntityTypeConfiguration<PessoaAfetada>
    {
        public void Configure(EntityTypeBuilder<PessoaAfetada> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomePessoa).HasMaxLength(100).IsRequired();
            builder.Property(p => p.TempoSintomas).IsRequired();
            builder.Property(p => p.QuantidadePessoas).IsRequired();
            builder.Property(p => p.ExameImagem).IsRequired();
            builder.HasOne(p => p.CasoDengue).WithMany(p => p.TodasPessoasAfetadas).HasForeignKey(p => p.IdCasoDengue);
        }
    }
}
