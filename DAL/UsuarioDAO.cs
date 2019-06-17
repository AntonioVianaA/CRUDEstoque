using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DAL
{
    class UsuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Buscar Usuario por Login
        public static Usuario BuscarUsuarioPorLogin(Usuario u)
        {
            return ctx.Usuario.FirstOrDefault(x => x.Login.Equals(u.Login));
        }
 

        //Metodo de Buscar Usuario por CPF 
        public static Usuario BuscarUsuarioPorCpf(Usuario u)
        {
            return ctx.Usuario.FirstOrDefault(x => x.Cpf.Equals(u.Cpf));
        }
        //Metodo de Cadastro de Usuario
        public static bool CadastrarUsuario(Usuario u)
        {
            if (BuscarUsuarioPorCpf(u) == null)
            {
                ctx.Usuario.Add(u);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        //Remove Usuario
        public static bool RemoverUsuario(Usuario u)
        {
            if (BuscarUsuarioPorCpf(u) != null)
            {
                ctx.Usuario.Remove(u);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        //Altera Usuario
        public static void AlterarUsuario(Usuario u)
        {

            ctx.Entry(u).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();

        }
    }
}
