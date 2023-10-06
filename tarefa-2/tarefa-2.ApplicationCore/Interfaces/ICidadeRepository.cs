using System.Collections.Generic;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.Entities;

namespace tarefa_2.ApplicationCore.Interfaces
{
    public interface ICidadeRepository
    {
        void Adicionar(Cidade entidade);
        void Atualizar(Cidade entidade);
        Task<Cidade> ObterPorIdAsync(int id);
        Task<List<Cidade>> ObterPorEstadoAsync(string estado);
        Task<List<Cidade>> ObterPorEstadoPaginadaAsync(string estado, int skip, int take);
        Task<Cidade> ObterPorNomeAsync(string nomeCidade);
    }
}