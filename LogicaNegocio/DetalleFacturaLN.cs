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
        public static decimal calcula2X1(int cantidad)
        {
            decimal costo = 0;
            foreach (Producto pro in ProductoLN.ObtenerTodos())
            {
                if (pro.nombreProducto.Equals("Gelatina") && cantidad == 2)
                {
                    costo = pro.precioProducto = pro.precioProducto / 2;
                }
            }
            return costo;
        }

        public static decimal calcularMontoVuelto(decimal totalCliente, decimal TotalPagar)
        {
            decimal monto = 0;
            if (totalCliente>=TotalPagar)
            {
                monto = totalCliente - TotalPagar;
            }
            else
            {
                monto = 0;
            }
            return monto;
        }








    }
}
