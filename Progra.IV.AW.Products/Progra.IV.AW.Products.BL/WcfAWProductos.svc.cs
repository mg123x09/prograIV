using System;
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
    public class WcfAWPrdouctos : IAWProductos
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

        public IList<Model.Product> ListarProductorPorColor(string Elcolor)
        {
            throw new NotImplementedException();
        }

        public IList<Model.Product> ListarProductosPorNombreDeCategoria(string laCategoria)
        {
            throw new NotImplementedException();
        }

        public IList<Model.Product> ListarProductosPorRangoDePrecio(decimal precioInferior, decimal precioSuperior)
        {
            throw new NotImplementedException();
        }
    }
}
