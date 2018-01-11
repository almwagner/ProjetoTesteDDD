using AutoMapper;
using ProjetoTesteDDD.MVC.ViewModels;
using ProjetoTesteDDD.MVC.WCFService;

namespace ProjetoTesteDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<TipoMaterial, TipoMaterialViewModel>();
            CreateMap<Material, MaterialViewModel>();
            CreateMap<Emprestimo, EmprestimoViewModel>();
        }
    }
}