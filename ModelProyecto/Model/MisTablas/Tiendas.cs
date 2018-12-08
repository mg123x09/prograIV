using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Tiendas
    {

        public string Direccion
        {

            get
            {

                string result = Provincia + "-" + Canton + "-" + Distrito + ".";
                if (Distrito == null)
                {
                    result = Provincia + "-" + Canton + ".";
                }
                return result;

            }
            set {
            }
        }
    }
}

