using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteDDD.Domain.Entities
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public int ClienteId { get; set; }
        public int MaterialId { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataDevolver { get; set; }
        public bool Devolvido { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Material Material { get; set; }
    }
}
