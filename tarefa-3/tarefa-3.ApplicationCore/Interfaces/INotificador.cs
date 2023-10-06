using System.Collections.Generic;
using tarefa_3.ApplicationCore.Notificador;

namespace tarefa_3.ApplicationCore.Interfaces
{
    public interface INotificador
    {
        void Adicionar(Notificacao notificacao);
        Dictionary<string, string[]> ObterNotificacoes();
        bool TemNotificacao();
    }
}