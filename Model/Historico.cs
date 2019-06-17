using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("Historico")]
    class Historico
    {
        public Historico()
        {
            Data = DateTime.Now;
        }

        [Key]
        public int HistoricoID { get; set; }
        public double ValorTotal { get; set; }
        public double ValorGasto { get; set; }
        public double Lucro { get; set; }
        public DateTime Data { get; set; }
    }
}
