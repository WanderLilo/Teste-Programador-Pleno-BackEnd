using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_3.ApplicationCore.Entities
{
    public class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int CidadeId { get; set; }   
    }
}
