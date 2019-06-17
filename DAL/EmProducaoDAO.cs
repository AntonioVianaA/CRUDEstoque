using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DAL
{
    class EmProducaoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static void CadastrarProducao(EmProducao ep)
        {
                ctx.EmProducao.Add(ep);
                ctx.SaveChanges();
        }
    }
}
