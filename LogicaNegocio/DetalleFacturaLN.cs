using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
   public class DetalleFacturaLN
    {
        public void calcula2X1()
        {
            foreach (Producto pro in ProductoLN.ObtenerTodos())
            {
                if (pro.nombreProducto.Equals("Gelatina"))
                {
                    pro.precioProducto = pro.precioProducto / 2;
                }
            }
        }




        




    }
}
