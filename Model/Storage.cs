using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("Storage")]
    class Storage
    {


        [Key]
        public int StorageID { get; set; }
        public Ingrediente Ingrediente { get; set; }


    }
}
