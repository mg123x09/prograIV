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
           var elResultdo = _contexto.Product.Where(p => p.Color.Contains(Elcolor)).ToList();/*el .ToList() es para traerlo desde la BD*/
            return elResultdo;
        }

        public IList<Class.ComboDeProductos> ListarIdYNombreDeProductoPorColor(string Elcolor)
        {
            var laListaDeProductos = _contexto.Product.Where
                (p => p.Color.Contains(Elcolor)).ToList();
            /*NO HACE EL ACCESO A LA BASE DE DATOS XQ ES IQUERABLE 'INIC9IAL EL SELECT PERO NO LA ACCEDE'*/

            IList<Class.ComboDeProductos> elResultado =
                laListaDeProductos.Select(p => new Class.ComboDeProductos
                {
                    idProducto = p.ProductID,
                    NombreProducto = p.Name
                }).ToList();

            return elResultado;
                
        }

    }//Fin de la clase
}
