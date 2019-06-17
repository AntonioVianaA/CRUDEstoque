using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DAL
{
    class EstoqueDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Busca de Ingredientes
        public static Ingrediente BuscarIngrediente(Ingrediente i)
        {
            return ctx.Ingrediente.SingleOrDefault(x => x.Nome.Equals(i.Nome));
        }

        public static Storage BuscarIngredienteEstoque(Storage s)
        {
            return ctx.Storage.Include("Ingrediente").FirstOrDefault(x => x.Ingrediente.IngredienteID.Equals(s.Ingrediente.IngredienteID));
        }

        //Metodo de Cadastro de Ingrediente
        public static Ingrediente CadastrarIngrediente(Ingrediente i)
        {
            
            Console.WriteLine("Digite a Descrição do Ingrediente:");
            i.Descricao = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Ingrediente:");
            i.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade a ser inserida no estoque:");
            i.QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a validade do ingrediente");
            i.Validade = Convert.ToDateTime(Console.ReadLine());
            ctx.Ingrediente.Add(i);
            ctx.SaveChanges();
            return i;
        }

        public static bool CadastrarIngredienteStr(Storage s, Ingrediente i)
        {
            Storage e = ctx.Storage.Include("Ingrediente").FirstOrDefault(x => x.Ingrediente.IngredienteID == s.Ingrediente.IngredienteID);
            Ingrediente ingrediente = CadastrarIngrediente(i);
            if (e == null)
            {
                s.Ingrediente = ingrediente;
                ctx.Storage.Add(s);
                ctx.SaveChanges();
                return true;
            }
            AlterarIngredienteStr(e);
            Console.WriteLine("Ingrediente alterado no Estoque");
            return false;
        }

        //Metodo de Cadastro de Ingrediente
        public static bool CadastrarIngredienteEstoque(Ingrediente i)
        {
            if (BuscarIngrediente(i) == null)
            {
                ctx.Ingrediente.Add(i);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        ////Remover Receita
        //public static bool RemoverIngredienteStr(Storage s)
        //{
        //    if (BuscarIngredienteStr(s) != null)
        //    {
        //        ctx.Storage.Remove(s);
        //        ctx.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}

        //Alterar Ingrediente que ja esta cadastrado no Stoque
        public static void AlterarIngredienteStr(Storage e)
        {
            Console.WriteLine("\nDigite a quantidade:");
            e.Ingrediente.QuantidadeEstoque += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a data de validae:");
            e.Ingrediente.Validade = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o Preço");
            e.Ingrediente.Preco = Convert.ToDouble(Console.ReadLine());
            ctx.Entry(e).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
