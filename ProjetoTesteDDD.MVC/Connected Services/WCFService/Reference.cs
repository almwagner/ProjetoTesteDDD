﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoTesteDDD.MVC.WCFService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/ProjetoTesteDDD.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClienteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClienteId {
            get {
                return this.ClienteIdField;
            }
            set {
                if ((this.ClienteIdField.Equals(value) != true)) {
                    this.ClienteIdField = value;
                    this.RaisePropertyChanged("ClienteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoMaterial", Namespace="http://schemas.datacontract.org/2004/07/ProjetoTesteDDD.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class TipoMaterial : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DevolucaoEmDiasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipoMaterialIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DevolucaoEmDias {
            get {
                return this.DevolucaoEmDiasField;
            }
            set {
                if ((this.DevolucaoEmDiasField.Equals(value) != true)) {
                    this.DevolucaoEmDiasField = value;
                    this.RaisePropertyChanged("DevolucaoEmDias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TipoMaterialId {
            get {
                return this.TipoMaterialIdField;
            }
            set {
                if ((this.TipoMaterialIdField.Equals(value) != true)) {
                    this.TipoMaterialIdField = value;
                    this.RaisePropertyChanged("TipoMaterialId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Material", Namespace="http://schemas.datacontract.org/2004/07/ProjetoTesteDDD.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class Material : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaterialIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetoTesteDDD.MVC.WCFService.TipoMaterial TipoMaterialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipoMaterialIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaterialId {
            get {
                return this.MaterialIdField;
            }
            set {
                if ((this.MaterialIdField.Equals(value) != true)) {
                    this.MaterialIdField = value;
                    this.RaisePropertyChanged("MaterialId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetoTesteDDD.MVC.WCFService.TipoMaterial TipoMaterial {
            get {
                return this.TipoMaterialField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoMaterialField, value) != true)) {
                    this.TipoMaterialField = value;
                    this.RaisePropertyChanged("TipoMaterial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TipoMaterialId {
            get {
                return this.TipoMaterialIdField;
            }
            set {
                if ((this.TipoMaterialIdField.Equals(value) != true)) {
                    this.TipoMaterialIdField = value;
                    this.RaisePropertyChanged("TipoMaterialId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Emprestimo", Namespace="http://schemas.datacontract.org/2004/07/ProjetoTesteDDD.Domain.Entities")]
    [System.SerializableAttribute()]
    public partial class Emprestimo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetoTesteDDD.MVC.WCFService.Cliente ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClienteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataDevolucaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataDevolverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DevolvidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmprestimoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetoTesteDDD.MVC.WCFService.Material MaterialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaterialIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetoTesteDDD.MVC.WCFService.Cliente Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClienteId {
            get {
                return this.ClienteIdField;
            }
            set {
                if ((this.ClienteIdField.Equals(value) != true)) {
                    this.ClienteIdField = value;
                    this.RaisePropertyChanged("ClienteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataDevolucao {
            get {
                return this.DataDevolucaoField;
            }
            set {
                if ((this.DataDevolucaoField.Equals(value) != true)) {
                    this.DataDevolucaoField = value;
                    this.RaisePropertyChanged("DataDevolucao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataDevolver {
            get {
                return this.DataDevolverField;
            }
            set {
                if ((this.DataDevolverField.Equals(value) != true)) {
                    this.DataDevolverField = value;
                    this.RaisePropertyChanged("DataDevolver");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Devolvido {
            get {
                return this.DevolvidoField;
            }
            set {
                if ((this.DevolvidoField.Equals(value) != true)) {
                    this.DevolvidoField = value;
                    this.RaisePropertyChanged("Devolvido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmprestimoId {
            get {
                return this.EmprestimoIdField;
            }
            set {
                if ((this.EmprestimoIdField.Equals(value) != true)) {
                    this.EmprestimoIdField = value;
                    this.RaisePropertyChanged("EmprestimoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetoTesteDDD.MVC.WCFService.Material Material {
            get {
                return this.MaterialField;
            }
            set {
                if ((object.ReferenceEquals(this.MaterialField, value) != true)) {
                    this.MaterialField = value;
                    this.RaisePropertyChanged("Material");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaterialId {
            get {
                return this.MaterialIdField;
            }
            set {
                if ((this.MaterialIdField.Equals(value) != true)) {
                    this.MaterialIdField = value;
                    this.RaisePropertyChanged("MaterialId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetClienteAllWithFilters", ReplyAction="http://tempuri.org/IService/GetClienteAllWithFiltersResponse")]
        ProjetoTesteDDD.MVC.WCFService.Cliente[] GetClienteAllWithFilters(string id, string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetClienteAllWithFilters", ReplyAction="http://tempuri.org/IService/GetClienteAllWithFiltersResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Cliente[]> GetClienteAllWithFiltersAsync(string id, string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTipoMaterialAllWithFilters", ReplyAction="http://tempuri.org/IService/GetTipoMaterialAllWithFiltersResponse")]
        ProjetoTesteDDD.MVC.WCFService.TipoMaterial[] GetTipoMaterialAllWithFilters(string id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTipoMaterialAllWithFilters", ReplyAction="http://tempuri.org/IService/GetTipoMaterialAllWithFiltersResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.TipoMaterial[]> GetTipoMaterialAllWithFiltersAsync(string id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMaterialAllWithFilters", ReplyAction="http://tempuri.org/IService/GetMaterialAllWithFiltersResponse")]
        ProjetoTesteDDD.MVC.WCFService.Material[] GetMaterialAllWithFilters(string id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMaterialAllWithFilters", ReplyAction="http://tempuri.org/IService/GetMaterialAllWithFiltersResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Material[]> GetMaterialAllWithFiltersAsync(string id, string descricao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetClienteAll", ReplyAction="http://tempuri.org/IService/GetClienteAllResponse")]
        ProjetoTesteDDD.MVC.WCFService.Cliente[] GetClienteAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetClienteAll", ReplyAction="http://tempuri.org/IService/GetClienteAllResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Cliente[]> GetClienteAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTipoMaterialAll", ReplyAction="http://tempuri.org/IService/GetTipoMaterialAllResponse")]
        ProjetoTesteDDD.MVC.WCFService.TipoMaterial[] GetTipoMaterialAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTipoMaterialAll", ReplyAction="http://tempuri.org/IService/GetTipoMaterialAllResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.TipoMaterial[]> GetTipoMaterialAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMaterialAll", ReplyAction="http://tempuri.org/IService/GetMaterialAllResponse")]
        ProjetoTesteDDD.MVC.WCFService.Material[] GetMaterialAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMaterialAll", ReplyAction="http://tempuri.org/IService/GetMaterialAllResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Material[]> GetMaterialAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmprestimolAll", ReplyAction="http://tempuri.org/IService/GetEmprestimolAllResponse")]
        ProjetoTesteDDD.MVC.WCFService.Emprestimo[] GetEmprestimolAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmprestimolAll", ReplyAction="http://tempuri.org/IService/GetEmprestimolAllResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Emprestimo[]> GetEmprestimolAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetClienteById", ReplyAction="http://tempuri.org/IService/GetClienteByIdResponse")]
        ProjetoTesteDDD.MVC.WCFService.Cliente GetClienteById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetClienteById", ReplyAction="http://tempuri.org/IService/GetClienteByIdResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Cliente> GetClienteByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTipoMaterialById", ReplyAction="http://tempuri.org/IService/GetTipoMaterialByIdResponse")]
        ProjetoTesteDDD.MVC.WCFService.TipoMaterial GetTipoMaterialById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTipoMaterialById", ReplyAction="http://tempuri.org/IService/GetTipoMaterialByIdResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.TipoMaterial> GetTipoMaterialByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMaterialById", ReplyAction="http://tempuri.org/IService/GetMaterialByIdResponse")]
        ProjetoTesteDDD.MVC.WCFService.Material GetMaterialById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMaterialById", ReplyAction="http://tempuri.org/IService/GetMaterialByIdResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Material> GetMaterialByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmprestimoById", ReplyAction="http://tempuri.org/IService/GetEmprestimoByIdResponse")]
        ProjetoTesteDDD.MVC.WCFService.Emprestimo GetEmprestimoById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmprestimoById", ReplyAction="http://tempuri.org/IService/GetEmprestimoByIdResponse")]
        System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Emprestimo> GetEmprestimoByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddCliente", ReplyAction="http://tempuri.org/IService/AddClienteResponse")]
        void AddCliente(ProjetoTesteDDD.MVC.WCFService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddCliente", ReplyAction="http://tempuri.org/IService/AddClienteResponse")]
        System.Threading.Tasks.Task AddClienteAsync(ProjetoTesteDDD.MVC.WCFService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddTipoMaterial", ReplyAction="http://tempuri.org/IService/AddTipoMaterialResponse")]
        void AddTipoMaterial(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddTipoMaterial", ReplyAction="http://tempuri.org/IService/AddTipoMaterialResponse")]
        System.Threading.Tasks.Task AddTipoMaterialAsync(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddMaterial", ReplyAction="http://tempuri.org/IService/AddMaterialResponse")]
        void AddMaterial(ProjetoTesteDDD.MVC.WCFService.Material material);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddMaterial", ReplyAction="http://tempuri.org/IService/AddMaterialResponse")]
        System.Threading.Tasks.Task AddMaterialAsync(ProjetoTesteDDD.MVC.WCFService.Material material);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddEmprestimo", ReplyAction="http://tempuri.org/IService/AddEmprestimoResponse")]
        void AddEmprestimo(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddEmprestimo", ReplyAction="http://tempuri.org/IService/AddEmprestimoResponse")]
        System.Threading.Tasks.Task AddEmprestimoAsync(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateCliente", ReplyAction="http://tempuri.org/IService/UpdateClienteResponse")]
        void UpdateCliente(ProjetoTesteDDD.MVC.WCFService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateCliente", ReplyAction="http://tempuri.org/IService/UpdateClienteResponse")]
        System.Threading.Tasks.Task UpdateClienteAsync(ProjetoTesteDDD.MVC.WCFService.Cliente cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateTipoMaterial", ReplyAction="http://tempuri.org/IService/UpdateTipoMaterialResponse")]
        void UpdateTipoMaterial(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateTipoMaterial", ReplyAction="http://tempuri.org/IService/UpdateTipoMaterialResponse")]
        System.Threading.Tasks.Task UpdateTipoMaterialAsync(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateMaterial", ReplyAction="http://tempuri.org/IService/UpdateMaterialResponse")]
        void UpdateMaterial(ProjetoTesteDDD.MVC.WCFService.Material material);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateMaterial", ReplyAction="http://tempuri.org/IService/UpdateMaterialResponse")]
        System.Threading.Tasks.Task UpdateMaterialAsync(ProjetoTesteDDD.MVC.WCFService.Material material);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateEmprestimo", ReplyAction="http://tempuri.org/IService/UpdateEmprestimoResponse")]
        void UpdateEmprestimo(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateEmprestimo", ReplyAction="http://tempuri.org/IService/UpdateEmprestimoResponse")]
        System.Threading.Tasks.Task UpdateEmprestimoAsync(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DevolverEmprestimo", ReplyAction="http://tempuri.org/IService/DevolverEmprestimoResponse")]
        void DevolverEmprestimo(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DevolverEmprestimo", ReplyAction="http://tempuri.org/IService/DevolverEmprestimoResponse")]
        System.Threading.Tasks.Task DevolverEmprestimoAsync(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ProjetoTesteDDD.MVC.WCFService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ProjetoTesteDDD.MVC.WCFService.IService>, ProjetoTesteDDD.MVC.WCFService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Cliente[] GetClienteAllWithFilters(string id, string nome) {
            return base.Channel.GetClienteAllWithFilters(id, nome);
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Cliente[]> GetClienteAllWithFiltersAsync(string id, string nome) {
            return base.Channel.GetClienteAllWithFiltersAsync(id, nome);
        }
        
        public ProjetoTesteDDD.MVC.WCFService.TipoMaterial[] GetTipoMaterialAllWithFilters(string id, string descricao) {
            return base.Channel.GetTipoMaterialAllWithFilters(id, descricao);
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.TipoMaterial[]> GetTipoMaterialAllWithFiltersAsync(string id, string descricao) {
            return base.Channel.GetTipoMaterialAllWithFiltersAsync(id, descricao);
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Material[] GetMaterialAllWithFilters(string id, string descricao) {
            return base.Channel.GetMaterialAllWithFilters(id, descricao);
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Material[]> GetMaterialAllWithFiltersAsync(string id, string descricao) {
            return base.Channel.GetMaterialAllWithFiltersAsync(id, descricao);
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Cliente[] GetClienteAll() {
            return base.Channel.GetClienteAll();
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Cliente[]> GetClienteAllAsync() {
            return base.Channel.GetClienteAllAsync();
        }
        
        public ProjetoTesteDDD.MVC.WCFService.TipoMaterial[] GetTipoMaterialAll() {
            return base.Channel.GetTipoMaterialAll();
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.TipoMaterial[]> GetTipoMaterialAllAsync() {
            return base.Channel.GetTipoMaterialAllAsync();
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Material[] GetMaterialAll() {
            return base.Channel.GetMaterialAll();
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Material[]> GetMaterialAllAsync() {
            return base.Channel.GetMaterialAllAsync();
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Emprestimo[] GetEmprestimolAll() {
            return base.Channel.GetEmprestimolAll();
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Emprestimo[]> GetEmprestimolAllAsync() {
            return base.Channel.GetEmprestimolAllAsync();
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Cliente GetClienteById(int id) {
            return base.Channel.GetClienteById(id);
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Cliente> GetClienteByIdAsync(int id) {
            return base.Channel.GetClienteByIdAsync(id);
        }
        
        public ProjetoTesteDDD.MVC.WCFService.TipoMaterial GetTipoMaterialById(int id) {
            return base.Channel.GetTipoMaterialById(id);
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.TipoMaterial> GetTipoMaterialByIdAsync(int id) {
            return base.Channel.GetTipoMaterialByIdAsync(id);
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Material GetMaterialById(int id) {
            return base.Channel.GetMaterialById(id);
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Material> GetMaterialByIdAsync(int id) {
            return base.Channel.GetMaterialByIdAsync(id);
        }
        
        public ProjetoTesteDDD.MVC.WCFService.Emprestimo GetEmprestimoById(int id) {
            return base.Channel.GetEmprestimoById(id);
        }
        
        public System.Threading.Tasks.Task<ProjetoTesteDDD.MVC.WCFService.Emprestimo> GetEmprestimoByIdAsync(int id) {
            return base.Channel.GetEmprestimoByIdAsync(id);
        }
        
        public void AddCliente(ProjetoTesteDDD.MVC.WCFService.Cliente cliente) {
            base.Channel.AddCliente(cliente);
        }
        
        public System.Threading.Tasks.Task AddClienteAsync(ProjetoTesteDDD.MVC.WCFService.Cliente cliente) {
            return base.Channel.AddClienteAsync(cliente);
        }
        
        public void AddTipoMaterial(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial) {
            base.Channel.AddTipoMaterial(tipoMaterial);
        }
        
        public System.Threading.Tasks.Task AddTipoMaterialAsync(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial) {
            return base.Channel.AddTipoMaterialAsync(tipoMaterial);
        }
        
        public void AddMaterial(ProjetoTesteDDD.MVC.WCFService.Material material) {
            base.Channel.AddMaterial(material);
        }
        
        public System.Threading.Tasks.Task AddMaterialAsync(ProjetoTesteDDD.MVC.WCFService.Material material) {
            return base.Channel.AddMaterialAsync(material);
        }
        
        public void AddEmprestimo(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo) {
            base.Channel.AddEmprestimo(emprestimo);
        }
        
        public System.Threading.Tasks.Task AddEmprestimoAsync(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo) {
            return base.Channel.AddEmprestimoAsync(emprestimo);
        }
        
        public void UpdateCliente(ProjetoTesteDDD.MVC.WCFService.Cliente cliente) {
            base.Channel.UpdateCliente(cliente);
        }
        
        public System.Threading.Tasks.Task UpdateClienteAsync(ProjetoTesteDDD.MVC.WCFService.Cliente cliente) {
            return base.Channel.UpdateClienteAsync(cliente);
        }
        
        public void UpdateTipoMaterial(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial) {
            base.Channel.UpdateTipoMaterial(tipoMaterial);
        }
        
        public System.Threading.Tasks.Task UpdateTipoMaterialAsync(ProjetoTesteDDD.MVC.WCFService.TipoMaterial tipoMaterial) {
            return base.Channel.UpdateTipoMaterialAsync(tipoMaterial);
        }
        
        public void UpdateMaterial(ProjetoTesteDDD.MVC.WCFService.Material material) {
            base.Channel.UpdateMaterial(material);
        }
        
        public System.Threading.Tasks.Task UpdateMaterialAsync(ProjetoTesteDDD.MVC.WCFService.Material material) {
            return base.Channel.UpdateMaterialAsync(material);
        }
        
        public void UpdateEmprestimo(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo) {
            base.Channel.UpdateEmprestimo(emprestimo);
        }
        
        public System.Threading.Tasks.Task UpdateEmprestimoAsync(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo) {
            return base.Channel.UpdateEmprestimoAsync(emprestimo);
        }
        
        public void DevolverEmprestimo(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo) {
            base.Channel.DevolverEmprestimo(emprestimo);
        }
        
        public System.Threading.Tasks.Task DevolverEmprestimoAsync(ProjetoTesteDDD.MVC.WCFService.Emprestimo emprestimo) {
            return base.Channel.DevolverEmprestimoAsync(emprestimo);
        }
    }
}