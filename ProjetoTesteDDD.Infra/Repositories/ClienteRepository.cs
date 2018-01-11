using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoTesteDDD.Domain.Entities;
using ProjetoTesteDDD.Domain.Interfaces.Repositories;

namespace ProjetoTesteDDD.Infra.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> GetAllWithFilters(string id, string nome)
        {
            var clientes = GetAll();

            if (!string.IsNullOrEmpty(id))
                clientes = clientes.Where(c => c.ClienteId.Equals(Int32.Parse(id)));

            if (!string.IsNullOrEmpty(nome))
                clientes = clientes.Where(c => c.Nome.ToUpper().Contains(nome.ToUpper()));

            return clientes;
        }
    }
}
