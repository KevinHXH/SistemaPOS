using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class ProductoDatos
    {
        
        public static DataSet SeleccionarTodos()
        {
            Database db = DatabaseFactory.CreateDatabase("default");
            SqlCommand comando = new SqlCommand("SeleccionarTodosProducto");
            comando.CommandType = CommandType.StoredProcedure;
            DataSet ds = db.ExecuteReader(comando, "Producto");
            return ds;
        }
    }
}
