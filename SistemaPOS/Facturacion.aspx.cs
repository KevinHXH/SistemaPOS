using Entidad;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaPOS
{
    public partial class Facturacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProductoo.DataSource = ProductoLN.ObtenerTodos();
                ddlProductoo.DataTextField = "NombreProducto";
                ddlProductoo.DataValueField = "idProducto";
                ddlProductoo.DataBind();
            }
        }

        protected void linkLogout_Click(object sender, EventArgs e)
        {

        }

      

        protected void ddlProductoo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Agregar2_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto = ProductoLN.Obtener(Convert.ToInt32(ddlProductoo.SelectedValue));
            grvListado.DataSource = ProductoLN.ObtenerTodosPorProducto(producto);
            grvListado.DataBind();
        }
    }
}