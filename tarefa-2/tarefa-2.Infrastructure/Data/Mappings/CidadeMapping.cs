using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.Entities;

namespace tarefa_2.Infrastructure.Data.Mappings
{
    public class CidadeMapping : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("CIDADES");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Nome).HasMaxLength(60).IsRequired();
            builder.Property(p => p.EstadoId).HasMaxLength(2).IsRequired();

            builder.HasOne(p => p.Estado).WithMany(p => p.Cidades).HasForeignKey(p => p.EstadoId).OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(p => p.Nome);
        }
    }
}
