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
        List<Producto> listaX = new List<Producto>();
        List<Producto> lista = new List<Producto>();
        List<Producto> listaF = new List<Producto>();
        Producto producto = new Producto();
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

        protected void Agregar2_Click(object sender, EventArgs e) {
            
            //Producto en sesión se añade a nueva lista
            if (Session["lista"] != null)
            {
                listaX = (List<Producto>)Session["lista"];
            }
          
            //Se obtine el producto del combo 
            this.producto = ProductoLN.Obtener(Convert.ToInt32(ddlProductoo.SelectedValue));

            foreach (Producto pro in ProductoLN.ObtenerTodos())
            {
                if (pro.idProducto == this.producto.idProducto)
                {
                    calcula2X1();
                    listaX.Add(pro);
                    Session["lista"] = listaX;
                }
            }

            grvListado.DataSource = listaX;
            grvListado.DataBind();


            decimal total = 0, subtotal = 0, monto = 0, montoTotal = 0, precioProducto = 0;

            foreach (Producto p in listaX)
            { 
                 precioProducto = p.precioProducto;
                 subtotal = subtotal + precioProducto;            
                 monto = (subtotal + total);
                 montoTotal = monto + (monto * p.impuesto/100);
                txtSubTotal.Text = subtotal.ToString();
                TxtTotal.Text = montoTotal.ToString();
                Session["MontoTotal"] = TxtTotal.Text;
            }
        }
        public void calcula2X1()
        {
            foreach (Producto pro in ProductoLN.ObtenerTodos())
            {
                if (pro.nombreProducto.Equals("Gelatina"))
                {
                    pro.precioProducto = pro.precioProducto / 2;
                }
            }
        }

        public void calcula2X1Factura()
        {
            DetalleFacturaLN.calcula2X1(2);
        }


        protected void grvListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnDescuento_Click(object sender, EventArgs e)
        {
            int des = Convert.ToInt32(TxtDescuento.Text);
            decimal total = Convert.ToDecimal(txtSubTotal.Text);
           
            if (des <= 10 && des >= 1)
            {        
                TxtTotal.Text = ProductoLN.calcularDescuento(des, total).ToString();
            }
            else
            {
                LblMensaje.Text = "Descuento debe ser minimo de 1% y maximo de 10%";
            }

        }

        protected void BtnProcesarFactura_Click(object sender, EventArgs e)
        {
            Session["NombreCliente"] = txtNombreCliente.Text;
            Response.Redirect("Factura.aspx");
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            ////Obtener fila actual
            //GridViewRow currentRow = (GridViewRow)((TextBox)sender).Parent.Parent;
            //TextBox txtCantidad = (TextBox)currentRow.FindControl("CantidadComprar");
            //if (txtCantidad.Text != "")
            //{
            //    int cantidad = Convert.ToInt32(txtCantidad.Text);
            //    decimal total = 0, subtotal = 0, monto = 0, montoTotal = 0, precioProducto = 0;
            //    foreach (Producto p in listaX)
            //    {
            //        precioProducto = p.precioProducto * cantidad;
            //        subtotal = subtotal + precioProducto;
            //        monto = (subtotal + total);
            //        montoTotal = monto + (monto * p.impuesto / 100);
            //        txtSubTotal.Text = subtotal.ToString();
            //        TxtTotal.Text = montoTotal.ToString();
            //    }
            //}
        }

        protected void CantidadComprar_TextChanged(object sender, EventArgs e)
        {
            //Obtener fila actual
            GridViewRow currentRow = (GridViewRow)((TextBox)sender).Parent.Parent;
            TextBox txtCantidad = (TextBox)currentRow.FindControl("CantidadComprar");
            if (txtCantidad.Text != "")
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal total = 0, subtotal = 0, monto = 0, montoTotal = 0, precioProducto = 0;
                foreach (Producto p in listaX)
                {
                    precioProducto = p.precioProducto * cantidad;
                    subtotal = subtotal + precioProducto;
                    monto = (subtotal + total);
                    montoTotal = monto + (monto * p.impuesto / 100);
                    txtSubTotal.Text = subtotal.ToString();
                    TxtTotal.Text = montoTotal.ToString();
                }

            }
        }



    }
}