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
   public class ProductoLN
    {

        public static List<Producto> ObtenerTodosPorProducto(Producto producto)
        {
            List<Producto> lista = new List<Producto>();

            DataSet ds = ProductoDatos.SeleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Producto prod = new Producto();
                prod.idProducto = Convert.ToInt32(row["IdProducto"]);
                prod.nombreProducto = row["NombreProducto"].ToString();
                prod.precioProducto = Convert.ToDecimal(row["PrecioProducto"].ToString());
                prod.impuesto = Convert.ToInt32(row["Impuesto"].ToString());
                prod.estado = row["Estado"].ToString();
                lista.Add(prod);
            }
            return lista;
        }

        public static List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();
         
            DataSet ds = ProductoDatos.SeleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Producto prod = new Producto();
                prod.idProducto = Convert.ToInt32(row["IdProducto"]);
                prod.nombreProducto = row["NombreProducto"].ToString();
                prod.precioProducto = Convert.ToDecimal(row["PrecioProducto"].ToString());
                prod.impuesto = Convert.ToInt32(row["Impuesto"].ToString());
                prod.estado = row["Estado"].ToString();
                lista.Add(prod);
            }
            return lista;
        }

        public static Producto Obtener(int idProducto)
        {
            List<Producto> rol = ProductoLN.ObtenerTodos();
            Producto elemento = rol.
                Where(x => x.idProducto.Equals(idProducto)).First();
            if (elemento == null)
            {
                return elemento;
            }
            return elemento;
        }
    }
}
