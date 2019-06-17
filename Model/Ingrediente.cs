using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("Ingredientes")]
    class Ingrediente
    {
        public Ingrediente()
        {
            CadastradoEm = DateTime.Now;
        }
        [Key]
        public int IngredienteID { get; set; }
        public string Nome { get; set; }
        public DateTime CadastradoEm { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public DateTime Validade { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
