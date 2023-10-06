using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_3.ApplicationCore.Entities;

namespace tarefa_3.Infrastructure.Data.Context
{
    public class Tarefa3Contexto : DbContext
    {
        public Tarefa3Contexto(DbContextOptions<Tarefa3Contexto> contexto) : base(contexto)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Tarefa3Contexto).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
