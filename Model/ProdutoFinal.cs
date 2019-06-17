using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("ProdutoFinal")]
    class ProdutoFinal
    {
        public ProdutoFinal()
        {
            ProduzidoEm = DateTime.Now;
        }
        [Key]
        public int ProdutoID { get; set; }
        public Receita Receita { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public int Porcoes { get; set; }
        public DateTime ProduzidoEm { get; set; }
    }
}
