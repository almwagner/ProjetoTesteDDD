using ProjetoTesteDDD.Domain.Entities;
using ProjetoTesteDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteDDD.Infra.Repositories
{
    public class EmprestimoRepository : RepositoryBase<Emprestimo>, IEmprestimoRepository
    {
        public void Devolver(Emprestimo emprestimo)
        {
            emprestimo.Devolvido = true;
            emprestimo.DataDevolucao = DateTime.Now;

            Update(emprestimo);
        }
    }
}
