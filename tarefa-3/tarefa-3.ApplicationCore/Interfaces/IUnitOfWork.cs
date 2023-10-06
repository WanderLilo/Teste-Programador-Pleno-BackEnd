using System.Threading.Tasks;

namespace tarefa_3.ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitarAsync();
    }
}