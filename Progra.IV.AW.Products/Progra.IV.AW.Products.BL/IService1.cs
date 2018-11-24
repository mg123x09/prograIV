using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Progra.IV.AW.Products.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]/*Par la clase*/
    public interface IAWProductos
    {

        [OperationContract]/*Calificador se publican por un DNRY*/
        string GetData(int value); /*RECIBE UN INT DEVUELVE UN STRING*/

        [OperationContract]/*para os metodos de la clase*/
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]/*para os metodos de la clase*/
         IList<Class.Product>ListarProductosPorRangoDePrecio(decimal precioInferior, decimal precioSuperior);


        [OperationContract]/*para os metodos de la clase*/
        IList<Class.Product> ListarProductorPorColor(string Elcolor);

        [OperationContract]/*para os metodos de la clase*/
        IList<Class.Product> ListarProductosPorNombreDeCategoria(string laCategoria);
        





    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract] /*Para los tipo daos compuestos referenciados dentro de la clase*/
    public class CompositeType 
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]/*atributos dentro del tipo compuesto que estan referenciado dentro de la clase*/
        public bool BoolValue/*Campo 1*/
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue /*Campo 2*/
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
