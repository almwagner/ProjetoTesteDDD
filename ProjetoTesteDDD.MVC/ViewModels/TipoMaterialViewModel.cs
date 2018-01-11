using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTesteDDD.MVC.ViewModels
{
    public class TipoMaterialViewModel
    {
        [Key]
        public int TipoMaterialId { get; set; }

        [Display(Name ="Descrição")]
        [MaxLength(50,ErrorMessage ="Máximo de 50 caracteres")]
        [Required]
        public string Descricao { get; set; }

        [Required]
        [Display(Name ="Devolução (em dias)")]
        public int DevolucaoEmDias { get; set; }
    }
}