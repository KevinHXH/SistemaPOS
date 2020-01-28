using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {

        public int idProducto { get; set; }
        public String nombreProducto { get; set; }
        public decimal precioProducto { get; set; }
        public int impuesto { get; set; }
        public string estado { get; set; }

        public Producto()
        {

        }

        public Producto(int idProducto, string nombreProducto, decimal precioProducto, int impuesto, string estado)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.impuesto = impuesto;
            this.estado = estado;
        }
    }
}
