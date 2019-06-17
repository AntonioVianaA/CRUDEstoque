using Estoque.DAL;
using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.View
{
    class CadastrarIngrediente
    {

        public static void Renderizar()
        {
            Ingrediente i = new Ingrediente();
            Storage s = new Storage();

            Console.WriteLine("\nCADASTRO DE INGREDIENTES");
            Console.WriteLine("\nDigite o nome do Ingrediente:");
            i.Nome = Console.ReadLine();
            if (EstoqueDAO.BuscarIngrediente(i) == null)
            {
                
                //s = EstoqueDAO.BuscarIngredienteEstoque(s);
                if (EstoqueDAO.CadastrarIngredienteStr(s, i))
                {
                    //Aqui está cadastrando o ingrediente
                    Console.WriteLine("Ingrediente Cadastrado com Sucesso na base de dados e no Estoque UHUUUU");
                }
                else
                {
                    //Ja vai chamar função de alterar pelo DAO
                    Console.WriteLine("Ingrediente alterado com sucesso");
                }
            }
            else
            {
                Ingrediente ingrediente = EstoqueDAO.BuscarIngrediente(i);
                s.Ingrediente = ingrediente;

                //Aqui terá que chamar função de alterar
                Console.WriteLine("Se fudeu ja troxao");
            }

        } 
    }
}
