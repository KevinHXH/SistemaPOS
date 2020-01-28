using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class FormaPago
    {
        public int idFormaPago { get; set; }
        public string nombreFormaPago { get; set; }


        public FormaPago()
        {

        }

        public FormaPago(int idFormaPago, string nombre)
        {
            this.idFormaPago = idFormaPago;
            this.nombreFormaPago = nombreFormaPago;
        }
    }
}
