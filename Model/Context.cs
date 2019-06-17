using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    class Context : DbContext
    {

        public Context() : base("CakeControlTESTE") { }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<ProdutoFinal> ProdutoFinal { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<EmProducao> EmProducao { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<IngredienteReceita> IngredienteReceita { get; set; }

    }
}
