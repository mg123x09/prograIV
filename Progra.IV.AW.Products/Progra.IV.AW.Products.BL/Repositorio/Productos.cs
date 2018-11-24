using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra.IV.AW.Products.Repositorio
{
    internal class Productos /*NO DEBE SER PUBLICA*/
    {
        private Progra.IV.AW.Products.Class.AdventureWorks2016Entities _contexto = new Class.AdventureWorks2016Entities();
        public IList<Class.Product> ListarProductoPorColor(string Elcolor)
        {
           var elResultdo = _contexto.Product.Where(p => p.Color.Contains(Elcolor)).ToList();
            return elResultdo;
        }

    }
}
