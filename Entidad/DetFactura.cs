using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DetFactura
    {
        public int idDetFactura { get; set; }
        public EncFactura encFactura { get; set; }
        public FormaPago formaPago { get; set; }
        public Producto producto { get; set; }
        public string nombreProducto { get; set; }
        public decimal precioProducto { get; set; }
        public int cantidad { get; set; }
        public decimal descuento { get; set; }
        public int impuesto { get; set; }
        public decimal subTotal { get; set; }
        public decimal total { get; set; }

        public DetFactura()
        {

        }

        public DetFactura(int idDetFactura, EncFactura encFactura, FormaPago formaPago, Producto producto, string nombreProducto, decimal precioProducto, int cantidad, decimal descuento, int impuesto, decimal subTotal, decimal total)
        {
            this.idDetFactura = idDetFactura;
            this.encFactura = encFactura;
            this.formaPago = formaPago;
            this.producto = producto;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.cantidad = cantidad;
            this.descuento = descuento;
            this.impuesto = impuesto;
            this.subTotal = subTotal;
            this.total = total;
        }
    }
}
