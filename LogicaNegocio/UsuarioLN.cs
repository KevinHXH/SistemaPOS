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
        //Método Crear usuario
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

        public static string iniciarSesion(string usuario, string pass)
        {
            string userX = "";
            foreach (Usuario user in UsuarioLN.ObtenerTodos())
            {
                if (usuario.Equals(user.nombreUsuario) && pass.Equals(user.password) && user.tipoUsuario.idTipoUsuario == 1 || user.tipoUsuario.idTipoUsuario == 2)
                {                   
                   userX = "Facturacion.aspx";
                }
            }
            return userX;
        }

        public static string registrarUsuario(string u, string pass, int tipoUser)
        {
            string userX = "";
            //Crear nuevo usuario
            foreach (Usuario user in UsuarioLN.ObtenerTodos())
            {
                Usuario usuario = new Usuario();
                TipoUsuario tipo = new TipoUsuario();

                usuario.nombreUsuario = u;
                usuario.password = pass;

                tipo = TipoUsuarioLN.Obtener(tipoUser);
                usuario.tipoUsuario = tipo;

                UsuarioLN.crearUser(usuario);
                userX = "Facturacion.aspx";
            }
            return userX;
        }

        public static string regresar()
        {
            return "Login.aspx";
        }

       

    }
}
