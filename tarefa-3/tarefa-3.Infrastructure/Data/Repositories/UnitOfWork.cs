using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_3.ApplicationCore.Interfaces;
using tarefa_3.Infrastructure.Data.Context;

namespace tarefa_3.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private Tarefa3Contexto _contexto;

        public UnitOfWork(Tarefa3Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task CommitarAsync()
        {
            await _contexto.SaveChangesAsync();
        }
    }
}
