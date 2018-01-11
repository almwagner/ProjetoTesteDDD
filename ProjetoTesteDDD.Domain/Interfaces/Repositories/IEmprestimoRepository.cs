using ProjetoTesteDDD.Domain.Entities;

namespace ProjetoTesteDDD.Domain.Interfaces.Repositories
{
    public interface IEmprestimoRepository : IRepositoryBase<Emprestimo>
    {
        void Devolver(Emprestimo emprestimo);
    }
}
