using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.DTOs;
using tarefa_2.ApplicationCore.Entities;

namespace tarefa_2.Infrastructure.Data.Mappings
{
    public class EstadoMapping : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("ESTADOS");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasMaxLength(2).IsRequired();
            builder.Property(p => p.Nome).HasMaxLength(60).IsRequired();

            builder.HasIndex(p => p.Nome);    
        }
    }
}
