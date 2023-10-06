using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_2.ApplicationCore.Entities
{
    public class Cidade: EntidadeBase
    {
        public string Nome { get; set; }
        public string EstadoId { get; set;}
        public Estado Estado { get; set;}
    }
}
