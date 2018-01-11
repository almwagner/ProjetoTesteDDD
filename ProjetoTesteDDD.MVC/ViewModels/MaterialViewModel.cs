using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTesteDDD.MVC.ViewModels
{
    public class MaterialViewModel
    {
        [Key]
        public int MaterialId { get; set; }

        [Required]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [Display(Name ="Tipo de Material")]
        public int TipoMaterialId { get; set; }

        [ScaffoldColumn(false)]
        public IList<SelectListItem> TipoMateriais { get; set; }

        [ScaffoldColumn(false)]
        public string TipoMaterialDescricao { get; set; }
    }
}