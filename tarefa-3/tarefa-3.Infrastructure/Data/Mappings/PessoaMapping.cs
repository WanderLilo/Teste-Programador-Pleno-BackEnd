using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_3.ApplicationCore.Entities;

namespace tarefa_3.Infrastructure.Data.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("PESSOAS");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Nome).HasMaxLength(60).IsRequired();
            builder.Property(p => p.Cpf).HasMaxLength(14).IsRequired();

            builder.HasIndex(p => p.Nome);
        }
    }
}
