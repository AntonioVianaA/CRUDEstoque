using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    [Table("Usuario")]
    class Usuario
    {
        public Usuario()
        {
            DataCadastro = DateTime.Now;
            Endereco = new Endereco();
        }

        [Key]
        public int UsuarioID { get; set; }
        public ProdutoFinal Produto { get; set; }
        public Historico Historico { get; set; }
        public Endereco Endereco { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public double SaldoConta { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimoLogin { get; set; }
    }
}
