using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.Entities;
using tarefa_2.ApplicationCore.Interfaces;
using tarefa_2.Infrastructure.Data.Context;

namespace tarefa_2.Infrastructure.Data.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private Tarefa2Contexto _contexto;

        public EstadoRepository(Tarefa2Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Estado entidade)
        {
            _contexto.Estados.Add(entidade);
        }

        public void Atualizar(Estado entidade)
        {
            _contexto.Estados.Update(entidade);
        }

        public async Task<Estado> ObterPorIdAsync(string id)
        {
            return await _contexto.Estados.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Estado> ObterPorNomeAsync(string nomeEstado)
        {
            return await _contexto.Estados.AsNoTracking().FirstOrDefaultAsync(p => p.Nome == nomeEstado);
        }
    }

}
