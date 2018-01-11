using AutoMapper;
using ProjetoTesteDDD.MVC.ViewModels;
using ProjetoTesteDDD.MVC.WCFService;

namespace ProjetoTesteDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<TipoMaterialViewModel, TipoMaterial>();
            CreateMap<MaterialViewModel, Material>();
            CreateMap<EmprestimoViewModel, Emprestimo>();
        }
    }
}