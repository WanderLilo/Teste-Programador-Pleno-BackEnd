using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.DTOs;
using tarefa_2.ApplicationCore.Entities;

namespace tarefa_2.Infrastructure.Data.Context
{
    public class Tarefa2Contexto: DbContext
    {
        public Tarefa2Contexto(DbContextOptions<Tarefa2Contexto> contexto): base(contexto)
        {
        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Tarefa2Contexto).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
