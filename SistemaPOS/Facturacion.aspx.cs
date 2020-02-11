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
        List<Producto> prodSeleccionados = new List<Producto>();
        List<Producto> prodSeleccionadosAux = new List<Producto>();

        Producto producto = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProductoo.DataSource = ProductoLN.ObtenerTodos();
                ddlProductoo.DataTextField = "NombreProducto";
                ddlProductoo.DataValueField = "idProducto";
                ddlProductoo.DataBind();
                grvListado.DataSource = Session["lista"];
                grvListado.DataBind();
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
            this.producto = ProductoLN.Obtener(Convert.ToInt32(ddlProductoo.SelectedValue));
            Session["productoSeleccionado"] = this.producto;
            Producto prod = new Producto();
            prod = (Producto)Session["productoSeleccionado"];

            List<Producto> listaAux = new List<Producto>();
            listaAux.Add(prod);
            Session["lista"] = listaAux;

            List<Producto> listaFinal = (List<Producto>)Session["lista"];
            foreach (Producto p in listaFinal)
            {

            }
            grvListado.DataSource = listaFinal;
            grvListado.DataBind();

            foreach (Producto p in listaFinal)
            { 
                decimal subtotal = p.precioProducto;
                decimal total = 0;
                decimal monto = (subtotal + total);
                decimal montoTotal = monto + (monto * p.impuesto/100);

                txtSubTotal.Text = subtotal.ToString();
                TxtTotal.Text = montoTotal.ToString();
                
            }

        }

        protected void grvListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnDescuento_Click(object sender, EventArgs e)
        {
            int descuento = Convert.ToInt32(TxtDescuento.Text) / 100;
            decimal total = Convert.ToDecimal(TxtTotal.Text);

            decimal montoDes = total - (total * descuento);

            TxtTotal.Text = montoDes.ToString();
        }

        protected void BtnProcesarFactura_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "Factura Procesada con éxito";
            grvListado.DataBind();
        }
    }
}