using AutoMapper;

namespace ProjetoTesteDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegistersMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}