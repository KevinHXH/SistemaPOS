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
    public class TipoUsuarioLN
    {
        //Seleccionar todos los tipos de usuario
        public static List<TipoUsuario> ObtenerTodos()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();

            DataSet ds = TipoUsuarioDatos.SeleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                TipoUsuario tipo = new TipoUsuario();
                tipo.idTipoUsuario = Convert.ToInt32(row["IdTipoUsuario"]);
                tipo.nombreTipoUsuario = row["NombreTipoUsuario"].ToString();
                lista.Add(tipo);
            }
            return lista;
        }

        public static TipoUsuario Obtener(int idTipoUsuario)
        {
            List<TipoUsuario> rol = TipoUsuarioLN.ObtenerTodos();
            TipoUsuario elemento = rol.
                Where(x => x.idTipoUsuario.Equals(idTipoUsuario)).First();
            if (elemento == null)
            {
                return elemento;
            }
            return elemento;
        }



    }
}
