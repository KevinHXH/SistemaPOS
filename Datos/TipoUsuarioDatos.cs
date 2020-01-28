using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TipoUsuarioDatos
    {
        //SeleccionarTodos
        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("default");
            SqlCommand comando = new SqlCommand("SeleccionarTodosTipoUsuario");
            comando.CommandType = CommandType.StoredProcedure;
            DataSet ds = db.ExecuteReader(comando, "TipoUsuario");
            return ds;
        }



    }
}
