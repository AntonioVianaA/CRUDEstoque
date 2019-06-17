using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("Receita")]
    class Receita
    {
        public Receita()
        {
            IngredientesReceita = new List<IngredienteReceita>();
            CadastradadoEm = DateTime.Now;
        }
        [Key]
        public int ReceitaID { get; set; }
        public List<IngredienteReceita> IngredientesReceita { get; set; }
        public string ModoPreparo { get; set; }
        public string Nome { get; set; }
        public int Rendimento { get; set; }
        public DateTime TempoPreparo { get; set; }
        public DateTime CadastradadoEm { get; set; }
    }
}
