using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DAL
{
    class EnderecoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        ////Testar Metodo
        //public static Endereco BuscarEnderereo(Usuario u)
        //{
        //    return ctx.Endereco.FirstOrDefault(x => x.Login.Equals(u.Login));
        //}

    }
}
