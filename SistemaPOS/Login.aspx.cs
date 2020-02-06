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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    ddlTipoUsuario.DataSource = TipoUsuarioLN.ObtenerTodos();
                    ddlTipoUsuario.DataTextField = "nombreTipoUsuario";
                    ddlTipoUsuario.DataValueField = "idTipoUsuario";
                    ddlTipoUsuario.DataBind();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in UsuarioLN.ObtenerTodos())
            {
                if (txtUsuario.Text.Equals(user.nombreUsuario) && txtContrasena.Text.Equals(user.password) && user.tipoUsuario.idTipoUsuario==1 || user.tipoUsuario.idTipoUsuario==2)
                {
                    Session["usuario"] = user;
                    Response.Redirect("Facturacion.aspx");
                }
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void ddlTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}