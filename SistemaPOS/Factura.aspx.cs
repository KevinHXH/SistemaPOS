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
    public partial class Factura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlFormaPago.DataSource = FormaPagoLN.ObtenerTodos();
                ddlFormaPago.DataTextField = "nombreFormaPago";
                ddlFormaPago.DataValueField = "idFormaPago";
                ddlFormaPago.DataBind();
            }
            if (Session["NombreCliente"]!=null)
            {
                txtNombreCliente.Text = Session["NombreCliente"].ToString();
            }
            if (Session["lista"]!=null)
            {
                grvListado.DataSource = (List<Producto>)Session["lista"];
                grvListado.DataBind();
            }
            if (Session["MontoTotal"] != null)
            {
                TxtTotal.Text = Session["MontoTotal"].ToString();
            }
        }

        protected void linkLogout_Click(object sender, EventArgs e)
        {

        }

        protected void CantidadComprar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void grvListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Agregar2_Click(object sender, EventArgs e)
        {

        }

        protected void btnProcesar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Facturacion.aspx");
        }

        protected void btnCalcularVuelto_Click(object sender, EventArgs e)
        {
            decimal cliente = Convert.ToDecimal(txtMontoCliente.Text);
            decimal total = Convert.ToDecimal(TxtTotal.Text);
            if (DetalleFacturaLN.calcularMontoVuelto(cliente,total)>0)
            {
                txtVuelto.Text = DetalleFacturaLN.calcularMontoVuelto(cliente, total).ToString();
            }else
            {
                txtVuelto.Text = "El monto del cliente debe ser mayor al total a pagar";
            }
        }



    }
}