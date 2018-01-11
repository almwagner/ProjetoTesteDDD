using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTesteDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="Máximo de 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(250,ErrorMessage ="Máximo de 250 caracteres")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Required]
        [MaxLength(15,ErrorMessage ="Máximo de 15 caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required]
        [MaxLength(150,ErrorMessage ="Máximo de 150 caracteres")]
        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
    }
}