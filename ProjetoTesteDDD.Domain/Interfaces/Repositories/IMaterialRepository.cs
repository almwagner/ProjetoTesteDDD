using ProjetoTesteDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteDDD.Domain.Interfaces.Repositories
{
    public interface IMaterialRepository : IRepositoryBase<Material>
    {
        IEnumerable<Material> GetMaterialAllWithFilters(string id, string descricao);
    }
}
