using System.Collections.Generic;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.DTOs;

namespace tarefa_2.ApplicationCore.Interfaces
{
    public interface ICidadeService
    {
        Task<CidadeDTO> AdicionarAsync(CidadeDTO cidadeDTO);
        Task<CidadeDTO> AtualizarAsync(CidadeDTO cidadeDTO);
        Task<CidadeDTO> ObterPorIdAsync(int id);
        Task<List<CidadeDTO>> ObterPorEstadoAsync(string estado);
        Task<List<CidadeDTO>> ObterPorEstadoPaginadaAsync(string estado, int skip, int take);
        Task<CidadeDTO> ObterPorNomeAsync(string nomeCidade);
    }
}