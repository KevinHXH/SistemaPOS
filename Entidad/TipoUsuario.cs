using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public  class TipoUsuario
    {
        public int idTipoUsuario { get; set; }
        public string nombreTipoUsuario { get; set; }

        public TipoUsuario()
        {

        }

        public TipoUsuario(int idTipoUsuario, string nombreTipoUsuario)
        {
            this.idTipoUsuario = idTipoUsuario;
            this.nombreTipoUsuario = nombreTipoUsuario;
        }
    }
}
