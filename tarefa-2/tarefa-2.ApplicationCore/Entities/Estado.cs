using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_2.ApplicationCore.Entities
{
    public class Estado
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public List<Cidade> Cidades { get; set; }
    }
}
