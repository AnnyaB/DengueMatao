using DengueMatao.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DengueMatao.Infra.Data.EntityConfiguration
{
    public class CasoDengueConfiguration
    {
        public class PessoaAfetadaConfiguration : IEntityTypeConfiguration<CasoDengue>
        {
            public void Configure(EntityTypeBuilder<CasoDengue> builder)
            {
                builder.HasKey(c => c.Id);
                builder.Property(c => c.Cep).HasMaxLength(8).IsRequired();
                builder.Property(c => c.NomeRua).HasMaxLength(100).IsRequired();
                builder.Property(c => c.Bairro).HasMaxLength(100).IsRequired();
                builder.Property(c => c.NumeroCasa).IsRequired();
                builder.Property(c => c.DataRegistro).IsRequired();
            }
        }
    }
}
