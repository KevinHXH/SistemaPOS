using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class EncFactura
    {
        public int idEncFactura { get; set; }
        public string nombreNegocio { get; set; }
        public string correoNegocio { get; set; }
        public Usuario usuario { get; set; }
        public DateTime fechaFactura { get; set; }

        public EncFactura()
        {

        }

        public EncFactura(int idEncFactura, string nombreNegocio, string correoNegocio, Usuario usuario, DateTime fechaFactura)
        {
            this.idEncFactura = idEncFactura;
            this.nombreNegocio = nombreNegocio;
            this.correoNegocio = correoNegocio;
            this.usuario = usuario;
            this.fechaFactura = fechaFactura;
        }
    }
}
