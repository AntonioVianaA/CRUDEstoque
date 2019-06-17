//using Estoque.DAL;
//using Estoque.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Estoque.View
//{
//    class AdicionarIngredieteSTG
//    {
//        public static void Renderizar()
//        {
//            do
//            {

//                Ingrediente i = new Ingrediente();
//                Historico h = new Historico();
//                Storage s = new Storage();

//                //No site tera uma tabela do estoque e tera um sinal de mais cujo significado é a adição de ingredientes no estoque, como se fosse a compra desses ingredientes

//                Console.WriteLine("ADICIONAR INGREDIENTES NO ESTOQUE (+)");

//                //Assim que clicar no +, abrirá um formulário com pedindo as seguintes informações: Nome do Ingrediente(DropDownList que contem os ingredientes cadastrados), e quantidade

//                Console.WriteLine("\nDigite o nome do Ingrediente:");
//                i.Nome = Console.ReadLine();
//                //i = IngredienteDAO.BuscarIngrediente(i);
//                if (i != null)
//                {
//                    Console.WriteLine("\nDigite a quantidade do Ingrediente a ser adicionada:");
//                    i.QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("\nInforme o preço atual do ingrediente:");
//                    i.Preco = Convert.ToDouble(Console.ReadLine());
//                    i.CadastradoEm = DateTime.Now;
//                    s.Ingrediente = i;
//                    s = EstoqueDAO.BuscarIngredienteStr(s);
//                    if (s != null)
//                    {
//                        EstoqueDAO.AlterarIngredienteStr(s);
//                        Console.WriteLine("\nIngrediente Adicionado com Sucesso!");
//                    }
//                    else
//                    {
//                        EstoqueDAO.CadastrarIngredienteStr(s);
//                        Console.WriteLine("\nIngrediente cadastrado no Estoque e adicionado com Sucesso!");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("\nIngrediente não encontrado");
//                }
//                Console.WriteLine("Deseja adicionar mais ingredientes ao estoque? S/N");
//            } while (Console.ReadLine().ToUpper().Equals("S"));
//        }
//    }
//}
