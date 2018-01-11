using ProjetoTesteDDD.Domain.Entities;
using ProjetoTesteDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteDDD.Infra.Repositories
{
    public class MaterialRepository : RepositoryBase<Material>, IMaterialRepository
    {
        public IEnumerable<Material> GetMaterialAllWithFilters(string id, string descricao)
        {
            var materiais = GetAll();

            if (!string.IsNullOrEmpty(id))
                materiais = materiais.Where(m => m.MaterialId.Equals(Int32.Parse(id)));

            if (!string.IsNullOrEmpty(descricao))
                materiais = materiais.Where(m => m.Descricao.Contains(descricao));

            return materiais;
        }
    }
}
