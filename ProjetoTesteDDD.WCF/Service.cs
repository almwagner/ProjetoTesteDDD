using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProjetoTesteDDD.Domain.Entities;
using ProjetoTesteDDD.Infra.Repositories;

namespace ProjetoTesteDDD.WCF
{
    public class Service : IService
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();
        private readonly TipoMaterialRepository _tipoMaterialRepository = new TipoMaterialRepository();
        private readonly MaterialRepository _materialRepository = new MaterialRepository();
        private readonly EmprestimoRepository _emprestimoRepository = new EmprestimoRepository();

        public void AddCliente(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
        }

        public void AddEmprestimo(Emprestimo emprestimo)
        {
            _emprestimoRepository.Add(emprestimo);
        }

        public void AddMaterial(Material material)
        {
            _materialRepository.Add(material);
        }

        public void AddTipoMaterial(TipoMaterial cliente)
        {
            _tipoMaterialRepository.Add(cliente);
        }

        public void DevolverEmprestimo(Emprestimo emprestimo)
        {
            _emprestimoRepository.Devolver(emprestimo);
        }

        public IEnumerable<Cliente> GetClienteAll()
        {
            return _clienteRepository.GetAll();
        }

        public IEnumerable<Cliente> GetClienteAllWithFilters(string id, string nome)
        {
            return _clienteRepository.GetAllWithFilters(id, nome);
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public Emprestimo GetEmprestimoById(int id)
        {
            return _emprestimoRepository.GetById(id);
        }

        public IEnumerable<Emprestimo> GetEmprestimolAll()
        {
            return _emprestimoRepository.GetAll();
        }

        public IEnumerable<Material> GetMaterialAll()
        {
            return _materialRepository.GetAll();
        }

        public IEnumerable<Material> GetMaterialAllWithFilters(string id, string descricao)
        {
            return _materialRepository.GetMaterialAllWithFilters(id, descricao);
        }

        public Material GetMaterialById(int id)
        {
            return _materialRepository.GetById(id);
        }

        public IEnumerable<TipoMaterial> GetTipoMaterialAll()
        {
            return _tipoMaterialRepository.GetAll();
        }

        public IEnumerable<TipoMaterial> GetTipoMaterialAllWithFilters(string id, string descricao)
        {
            return _tipoMaterialRepository.GetAllTipoMateriaisWithFilters(id, descricao);
        }

        public TipoMaterial GetTipoMaterialById(int id)
        {
            return _tipoMaterialRepository.GetById(id);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }

        public void UpdateEmprestimo(Emprestimo emprestimo)
        {
            _emprestimoRepository.Update(emprestimo);
        }

        public void UpdateMaterial(Material material)
        {
            _materialRepository.Update(material);
        }

        public void UpdateTipoMaterial(TipoMaterial cliente)
        {
            _tipoMaterialRepository.Update(cliente);
        }
    }
}
