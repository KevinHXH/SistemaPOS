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
            
            if (Session["lista"] != null)
            {
                listaX = (List<Producto>)Session["lista"];
            }
            
            this.producto = ProductoLN.Obtener(Convert.ToInt32(ddlProductoo.SelectedValue));

            foreach (Producto pro in ProductoLN.ObtenerTodos())
            {
                if (pro.idProducto == this.producto.idProducto)
                {
                    calcula2X1();
                    lista.Add(pro);
                    Session["lista"] = lista;
                }
            }

            foreach (Producto prod in (List<Producto>)Session["lista"])
            {
                listaX.Add(prod);
                Session["listaF"] = listaX;
            }

            grvListado.DataSource = (List<Producto>)Session["listaF"];
            grvListado.DataBind();

            decimal total = 0;
            decimal subtotal = 0;
            decimal monto = 0;
            decimal montoTotal = 0;
            decimal precioProducto = 0;

            foreach (Producto p in (List<Producto>)Session["listaF"])
            { 
                 precioProducto = p.precioProducto;
                 subtotal = subtotal + precioProducto;            
                 monto = (subtotal + total);
                 montoTotal = monto + (monto * p.impuesto/100);

                txtSubTotal.Text = subtotal.ToString();
                TxtTotal.Text = montoTotal.ToString();
                
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

        protected void grvListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnDescuento_Click(object sender, EventArgs e)
        {
            int des = Convert.ToInt32(TxtDescuento.Text);
            decimal total = Convert.ToDecimal(txtSubTotal.Text);
            decimal desX = des*10;
            decimal desFinal = desX / 100;
            decimal desF2 = desFinal / 10;

            if (des<=10 && des>=1)
            {
                decimal montoDes = total - (total * desF2);
                TxtTotal.Text = montoDes.ToString();
            }else
            {
                LblMensaje.Text = "Descuento debe ser minimo de 1% y maximo de 10%";
            }

           
        }

        protected void BtnProcesarFactura_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "Factura Procesada con éxito";
            grvListado.DataBind();
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach (GridView row in grvListado.Rows)
            {
                TextBox txtr = (TextBox)grvListado.Rows[5].FindControl("txtCantidad");
                String res = txtr.Text;
                int cantidad = Convert.ToInt32(res);

                foreach(Producto p in (List<Producto>)Session["listaF"])
                {
                    String subtotal = txtSubTotal.Text;
                    string total = TxtTotal.Text;
                    decimal sub = Convert.ToDecimal(subtotal);
                    decimal tot = Convert.ToDecimal(total);

                    sub = (sub + p.precioProducto)*cantidad;
                    tot = tot + sub;

                    txtSubTotal.Text = sub.ToString();
                    TxtTotal.Text = tot.ToString();

                }
               

            }
         
        }



    }
}