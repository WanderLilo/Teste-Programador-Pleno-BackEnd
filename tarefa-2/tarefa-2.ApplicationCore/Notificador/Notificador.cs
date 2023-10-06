using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.Interfaces;

namespace tarefa_2.ApplicationCore.Notificador
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Adicionar(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public Dictionary<string, string[]> ObterNotificacoes()
        {
            var dicionarioNotificacoes = new Dictionary<string, string[]>();

            dicionarioNotificacoes.Add("ErrosValidacao", _notificacoes.Select(x => x.Mensagem).ToArray());

            return dicionarioNotificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }


    }
}
