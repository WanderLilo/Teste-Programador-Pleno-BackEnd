using System.Threading.Tasks;
using tarefa_3.ApplicationCore.DTOs;

namespace tarefa_3.ApplicationCore.Interfaces
{
    public interface IPessoaService
    {
        Task<PessoaDTO> AdicionarAsync(PessoaDTO pessoaDTO);
    }
}