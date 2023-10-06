using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.Interfaces;
using tarefa_2.Infrastructure.Data.Context;

namespace tarefa_2.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private Tarefa2Contexto _contexto;

        public UnitOfWork(Tarefa2Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task CommitarAsync()
        {
            await _contexto.SaveChangesAsync();
        }
    }
}
