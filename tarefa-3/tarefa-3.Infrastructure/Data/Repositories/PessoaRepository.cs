using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_3.ApplicationCore.Entities;
using tarefa_3.ApplicationCore.Interfaces;
using tarefa_3.Infrastructure.Data.Context;

namespace tarefa_3.Infrastructure.Data.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private Tarefa3Contexto _contexto;

        public PessoaRepository(Tarefa3Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Pessoa entidade)
        {
            _contexto.Pessoas.Add(entidade);
        }

    }

}
