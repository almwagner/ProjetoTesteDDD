using ProjetoTesteDDD.Domain.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace ProjetoTesteDDD.WCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        IEnumerable<Cliente> GetClienteAllWithFilters(string id, string nome);

        [OperationContract]
        IEnumerable<TipoMaterial> GetTipoMaterialAllWithFilters(string id, string descricao);

        [OperationContract]
        IEnumerable<Material> GetMaterialAllWithFilters(string id, string descricao);

        [OperationContract]
        IEnumerable<Cliente> GetClienteAll();

        [OperationContract]
        IEnumerable<TipoMaterial> GetTipoMaterialAll();

        [OperationContract]
        IEnumerable<Material> GetMaterialAll();

        [OperationContract]
        IEnumerable<Emprestimo> GetEmprestimolAll();

        [OperationContract]
        Cliente GetClienteById(int id);

        [OperationContract]
        TipoMaterial GetTipoMaterialById(int id);

        [OperationContract]
        Material GetMaterialById(int id);

        [OperationContract]
        Emprestimo GetEmprestimoById(int id);

        [OperationContract]
        void AddCliente(Cliente cliente);

        [OperationContract]
        void AddTipoMaterial(TipoMaterial tipoMaterial);

        [OperationContract]
        void AddMaterial(Material material);

        [OperationContract]
        void AddEmprestimo(Emprestimo emprestimo);

        [OperationContract]
        void UpdateCliente(Cliente cliente);

        [OperationContract]
        void UpdateTipoMaterial(TipoMaterial tipoMaterial);

        [OperationContract]
        void UpdateMaterial(Material material);

        [OperationContract]
        void UpdateEmprestimo(Emprestimo emprestimo);

        [OperationContract]
        void DevolverEmprestimo(Emprestimo emprestimo);
    }
}
