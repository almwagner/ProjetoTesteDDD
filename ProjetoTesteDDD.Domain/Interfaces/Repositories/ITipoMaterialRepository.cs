using ProjetoTesteDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteDDD.Domain.Interfaces.Repositories
{
    public interface ITipoMaterialRepository : IRepositoryBase<TipoMaterial>
    {
        IEnumerable<TipoMaterial> GetAllTipoMateriaisWithFilters(string id, string descricao);
    }
}
