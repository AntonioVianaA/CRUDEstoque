using Estoque.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            do
            {

                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("1) Cadastrar Ingredientes no Banco de Dados");
                Console.WriteLine("2) Adicionar Ingredientes ao Estoque(Comprar = Gasto)");
                Console.WriteLine("3) Cadastrar Receita");
                Console.WriteLine("4) Adicionar Prato(Receita) em produção(Saída = Lucro)");
                Console.WriteLine("0) Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CadastrarIngrediente.Renderizar();
                        break;
                    case 2:
                        //AdicionarIngredieteSTG.Renderizar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo....");
                        break;

                    default:
                        break;
                }

            } while (op != 0);





            Console.WriteLine("Precione alguma tecla para continuar:");
            Console.ReadKey();

        }
    }
}
