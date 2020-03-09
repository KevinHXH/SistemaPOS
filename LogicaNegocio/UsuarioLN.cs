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

        public static Usuario iniciarSesion(string usuario, string pass)
        {
            Usuario u = new Usuario();  
            foreach (Usuario user in UsuarioLN.ObtenerTodos())
            {
                if (usuario.Equals(user.nombreUsuario) && pass.Equals(user.password) && user.tipoUsuario.idTipoUsuario == 1 || user.tipoUsuario.idTipoUsuario == 2)
                {
                   u = user;
                }
            }
            return u;
        }

        public static Usuario registrarUsuario(string u, string pass, int tipoUser)
        {
            Usuario usuario = new Usuario();
            TipoUsuario tipo = new TipoUsuario();
            //Crear nuevo usuario
            foreach (Usuario user in UsuarioLN.ObtenerTodos())
            {
                usuario.nombreUsuario = u;
                usuario.password = pass;

                tipo = TipoUsuarioLN.Obtener(tipoUser);
                usuario.tipoUsuario = tipo;

                UsuarioLN.crearUser(usuario);
            }
            return usuario;
        }

        public static string regresar()
        {
            return "Login.aspx";
        }

       

    }
}
