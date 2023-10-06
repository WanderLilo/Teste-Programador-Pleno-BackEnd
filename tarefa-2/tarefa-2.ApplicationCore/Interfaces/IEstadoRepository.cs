using System.Threading.Tasks;
using tarefa_2.ApplicationCore.Entities;

namespace tarefa_2.Infrastructure.Data.Repositories
{
    public interface IEstadoRepository
    {
        void Adicionar(Estado entidade);
        void Atualizar(Estado entidade);
        Task<Estado> ObterPorIdAsync(string id);
        Task<Estado> ObterPorNomeAsync(string nomeEstado);
    }
}