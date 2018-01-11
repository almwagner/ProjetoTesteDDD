using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ProjetoTesteDDD.Domain.Interfaces.Repositories;

namespace ProjetoTesteDDD.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private static IList<TEntity> _entityAll = new List<TEntity>();
        private static readonly string entityName = typeof(TEntity).UnderlyingSystemType.Name;
        private static PropertyInfo propertyId = typeof(TEntity).GetProperty(entityName + "Id");

        public void Add(TEntity entity)
        {
            lock(_entityAll)
            {
                int maxId = _entityAll.Max(e => propertyId.GetValue(e)) == null ? 0 : _entityAll.Max(e => propertyId.GetValue(e).GetHashCode());

                propertyId.SetValue(entity, maxId + 1);

                _entityAll.Add(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            lock(_entityAll)
            {
                TEntity entityRemove = _entityAll.Where(e => propertyId.GetValue(e).Equals(propertyId.GetValue(entity))).FirstOrDefault();
                _entityAll.Remove(entityRemove);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entityAll;
        }

        public TEntity GetById(int id)
        {
            return _entityAll.Where(e => propertyId.GetValue(e).Equals(id)).FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            lock (_entityAll)
            {
                TEntity entityRemove = _entityAll.Where(e => propertyId.GetValue(e).Equals(propertyId.GetValue(entity))).FirstOrDefault();
                _entityAll.Remove(entityRemove);
                _entityAll.Add(entity);
            }
        }
    }
}
