using System.Threading.Tasks;

namespace tarefa_2.ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitarAsync();
    }
}