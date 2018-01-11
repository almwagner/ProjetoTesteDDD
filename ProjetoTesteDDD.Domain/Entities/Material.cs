namespace ProjetoTesteDDD.Domain.Entities
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string Descricao { get; set; }
        public int TipoMaterialId { get; set; }
        public virtual TipoMaterial TipoMaterial { get; set; }
    }
}
