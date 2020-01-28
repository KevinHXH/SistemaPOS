using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public class Usuario
    {
        public int idUsuario { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }

        public Usuario()
        {

        }

        public Usuario(int idUsuario, TipoUsuario tipoUsuario, string nombreUsuario, string password)
        {
            this.idUsuario = idUsuario;
            this.tipoUsuario = tipoUsuario;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
        }
    }
}
