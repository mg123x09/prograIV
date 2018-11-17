using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Progra.IV.AW.Products.Class
{
    public partial class Product
    {
        public string sizeInInches { get {
                string elResutado = Size;

                if (SizeUnitMeasureCode != null && SizeUnitMeasureCode == "CM")
                {
                    float eltamanoFloat = 0;
                   if( float.TryParse(Size, out eltamanoFloat))   
                    elResutado = (eltamanoFloat / (float)2.54).ToString();
                    
                }
                return elResutado;
                
            }
        set { } //* no hay que poner valor por lo que no tinene set

        }
    }
}
