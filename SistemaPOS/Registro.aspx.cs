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
    public partial class Registro : System.Web.UI.Page
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

        protected void btnRegistar_Click(object sender, EventArgs e)
        {
            //Crear nuevo usuario
            foreach (Usuario user in UsuarioLN.ObtenerTodos())
            {
                    Usuario usuario = new Usuario();
                    TipoUsuario tipo = new TipoUsuario();

                    usuario.nombreUsuario = txtUsuario.Text;
                    usuario.password = txtContrasena.Text;
                    
                    tipo = TipoUsuarioLN.Obtener(Convert.ToInt32(ddlTipoUsuario.SelectedValue));
                    usuario.tipoUsuario = tipo;
             
                    UsuarioLN.crearUsuario(usuario);
                    Response.Redirect("Facturacion.aspx");
            }
        }

        protected void Regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void ddlTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}