using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTesteDDD.MVC.ViewModels
{
    public class EmprestimoViewModel
    {
        [Key]
        public int EmprestimoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Material")]
        public int MaterialId { get; set; }

        [ScaffoldColumn(false)]
        public bool Devolvido { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDevolucao { get; set; }

        [ScaffoldColumn(false)]
        public string DataDevolucaoDescricao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDevolver { get; set; }

        [ScaffoldColumn(false)]
        public string DataDevolverDescricao { get; set; }

        [ScaffoldColumn(false)]
        public string DevolvidoDescricao { get; set; }

        [ScaffoldColumn(false)]
        public IList<SelectListItem> Clientes { get; set; }

        [ScaffoldColumn(false)]
        public IList<SelectListItem> Materiais { get; set; }

        [ScaffoldColumn(false)]
        public string ClienteNome { get; set; }

        [ScaffoldColumn(false)]
        public string MaterialDescricao { get; set; }
    }
}