using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class UsuarioDatos
    {
        //Insertar nuevo usuario
        public static void Insertar(Usuario usuario)
        {
            Database db = DatabaseFactory.CreateDatabase("default");
            SqlCommand comando = new SqlCommand("InsertarUsuario");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdTipoUsuario", usuario.tipoUsuario.idTipoUsuario);
            comando.Parameters.AddWithValue("@NombreUsuario", usuario.nombreUsuario);
            comando.Parameters.AddWithValue("@Password", usuario.password);
            db.ExecuteNonQuery(comando);
        }

        //SeleccionarTodos
        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("default");
            SqlCommand comando = new SqlCommand("SeleccionarTodosUsuario");
            comando.CommandType = CommandType.StoredProcedure;
            DataSet ds = db.ExecuteReader(comando, "Usuario");
            return ds;
        }



    }
}
