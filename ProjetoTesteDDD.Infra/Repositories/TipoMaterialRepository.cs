using ProjetoTesteDDD.Domain.Entities;
using ProjetoTesteDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteDDD.Infra.Repositories
{
    public class TipoMaterialRepository : RepositoryBase<TipoMaterial>, ITipoMaterialRepository
    {
        public IEnumerable<TipoMaterial> GetAllTipoMateriaisWithFilters(string id, string descricao)
        {
            var tipoMateriais = GetAll();

            if (!string.IsNullOrEmpty(id))
                tipoMateriais = tipoMateriais.Where(t => t.TipoMaterialId.Equals(Int32.Parse(id)));

            if (!string.IsNullOrEmpty(descricao))
                tipoMateriais = tipoMateriais.Where(t => t.Descricao.Contains(descricao));

            return tipoMateriais;
        }
    }
}
