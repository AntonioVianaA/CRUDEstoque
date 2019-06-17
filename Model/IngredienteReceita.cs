using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("IngredientesReceita")]
    class IngredienteReceita
    {
        public IngredienteReceita()
        {

        }
        [Key]
        public int Ingredientes_ReceitaID { get; set; }
        public List<Ingrediente> Ingrediente { get; set; }
        public int QuantidadeNecessaria { get; set; }
    }
}
