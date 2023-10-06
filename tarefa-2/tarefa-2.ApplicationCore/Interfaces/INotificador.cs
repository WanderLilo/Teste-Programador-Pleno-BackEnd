using System.Collections.Generic;
using tarefa_2.ApplicationCore.Notificador;

namespace tarefa_2.ApplicationCore.Interfaces
{
    public interface INotificador
    {
        void Adicionar(Notificacao notificacao);
        Dictionary<string, string[]> ObterNotificacoes();
        bool TemNotificacao();
    }
}