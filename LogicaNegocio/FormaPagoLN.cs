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
    public class FormaPagoLN
    {
        public static List<FormaPago> ObtenerTodos()
        {
            List<FormaPago> lista = new List<FormaPago>();

            DataSet ds = FormaPagoDatos.SeleccionarTodos();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                FormaPago pago = new FormaPago();
                pago.idFormaPago = Convert.ToInt32(row["IdFormaPago"]);
                pago.nombreFormaPago = row["NombreFormaPago"].ToString();
                lista.Add(pago);
            }
            return lista;
        }

        public static int medioPago(int formaPago)
        {
            if (formaPago==1)
            {

            }
            return 1;
        }



    }
}
