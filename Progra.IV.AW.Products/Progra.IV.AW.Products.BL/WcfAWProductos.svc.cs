﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Progra.IV.AW.Products.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WcfAWProductos : IAWProductos
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public IList<Class.Product> ListarProductoPorColor(string elColor)
        {
           var elRepositorio = new Repositorio.Productos();
            var elResultado = elRepositorio.ListarProductoPorColor(elColor);
            return (elResultado);
        }

        

        public IList<Class.Product> ListarProductosPorNombreDeCategoria(string laCategoria)
        {
            throw new NotImplementedException();
        }

        public IList<Class.Product> ListarProductosPorRangoDePrecio(decimal precioInferior, decimal precioSuperior)
        {
            throw new NotImplementedException();
        }

          IList<Class.Product> IAWProductos.ListarProductorPorColor(string Elcolor)
        {
            throw new NotImplementedException();
        }

         IList<Class.Product> IAWProductos.ListarProductosPorNombreDeCategoria(string laCategoria)
        {
            throw new NotImplementedException();
        }

     IList<Class.Product> IAWProductos.ListarProductosPorRangoDePrecio(decimal precioInferior, decimal precioSuperior)
        {
            throw new NotImplementedException();
        }
    }
}
