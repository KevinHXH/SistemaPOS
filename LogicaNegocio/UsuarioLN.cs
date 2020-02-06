using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UsuarioLN
    {
        //Método Crear usuario valeriaM
        public static void crearUser(Usuario usuario)
        {
            UsuarioDatos.Insertar(usuario);
        }

        //SeleccionarTodos
        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            DataSet ds = UsuarioDatos.SeleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Usuario usua = new Usuario();
                usua.idUsuario = Convert.ToInt32(row["IdUsuario"]);
                usua.tipoUsuario = TipoUsuarioLN.Obtener(Convert.ToInt32(row["IdTipoUsuario"]));
                usua.nombreUsuario = row["NombreUsuario"].ToString();
                usua.password = row["Password"].ToString();
                lista.Add(usua);
            }
            return lista;
        }


       

    }
}
