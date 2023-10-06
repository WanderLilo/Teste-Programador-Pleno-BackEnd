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
    public class CidadeRepository : ICidadeRepository
    {
        private Tarefa2Contexto _contexto;

        public CidadeRepository(Tarefa2Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Cidade entidade)
        {
            _contexto.Cidades.Add(entidade);
        }

        public void Atualizar(Cidade entidade)
        {
            _contexto.Cidades.Update(entidade);
        }

        public async Task<Cidade> ObterPorIdAsync(int id)
        {
            return await _contexto.Cidades.AsNoTracking().FirstOrDefaultAsync( p => p.ID == id);
        }

        public async Task<List<Cidade>> ObterPorEstadoAsync(string estado)
        {
            return await _contexto.Cidades.AsNoTracking().Where(p => p.EstadoId == estado).ToListAsync();
        }

        public async Task<List<Cidade>> ObterPorEstadoPaginadaAsync(string estado, int skip, int take)
        {
            return await _contexto.Cidades.AsNoTracking().Where(p => p.EstadoId == estado).Skip(skip).Take(take).ToListAsync();
        }


        public async Task<Cidade> ObterPorNomeAsync(string nomeCidade)
        {
            return await _contexto.Cidades.AsNoTracking().FirstOrDefaultAsync(p => p.Nome == nomeCidade);
        }
    }

}
