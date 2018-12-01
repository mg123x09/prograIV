using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra.IV.AW.Products.AccesoBL
{
    class Productos
    {
        public IList<Class.Product> ListarProductoPorColor(string elColor)
        {


            var elClienteWcf = new SI.WcfProductos.AWProductosClient();
            var elResultado = elClienteWcf.ListarProductorPorColor(elColor);
            elClienteWcf.Close();
            return elResultado;
    }



        public IList<Class.ComboDeProductos> ListarIdYNombreDeProductoPorColor(string elColor)
        {


            var elClienteWcf = new SI.WcfProductos.AWProductosClient();
            var elResultado = elClienteWcf.ListarIdYNombreDeProductoPorColor(elColor);
            elClienteWcf.Close();
            return elResultado;
        }
    }
}
