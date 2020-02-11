<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="SistemaPOS.Facturacion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="description" content=""/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>Facturación</title>
 <!-- Favicon  -->
    <link rel="icon" href="img/core-img/favicon.ico"/>
    <!-- Core Style CSS -->
    <link rel="stylesheet" href="css/core-style.css"/>
    <link rel="stylesheet" href="style.css"/>
    <!-- Responsive CSS -->
    <link rel="stylesheet" href="css/responsive.css"/>

     <style>

        .gradient-background-overlay:after, .background-overlay:after {
            background: linear-gradient(to right, #ff8000, #d16a0c);
        }

        div.top-header-area.gradient-background{
             background: linear-gradient(to right, #ff8000, #d16a0c);
        }

         .gradient-background-overlay:after, .background-overlay:after {

             height:30%;
         }

         .breadcumb-title{
             margin-top:-100px;
         }

    </style>
   
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="d-flex flex-column flex-md-row align-items-center p-3 px-md-4 mb-3 bg-white border-bottom shadow-sm">
            <h5 class="my-0 mr-md-auto font-weight-normal"></h5>
            <asp:Menu ID="Menu1"
                runat="server"
                Orientation="Horizontal"
                CssClass="my-2 my-md-0 mr-md-3">
                <StaticMenuStyle CssClass="p-2 text-dark" />
                <StaticSelectedStyle CssClass="active" />
                <DynamicMenuStyle CssClass="dropdown-menu" />
                <LevelMenuItemStyles>
                    <asp:MenuItemStyle CssClass="nav-item p-2 text-dark" />
                    <asp:MenuItemStyle CssClass="nav-item p-2 " ForeColor="#3333cc" />
                </LevelMenuItemStyles>
            </asp:Menu>
            
            <%-- Usuariooo --%>

            <span class="navbar-text">Usuario: 
            <asp:Label ID="lblNombreUsuario" 
                Visible="false"
                runat="server" Text="" CssClass="btn btn-outline-secondary"></asp:Label>
            <asp:LinkButton ID="linkLogout" 
                Visible="false"
                runat="server" 
                CssClass="btn btn-outline-primary"
                OnClick="linkLogout_Click">Cerrar Sesión</asp:LinkButton>
            </span>
            <asp:LinkButton ID="linkRegistrarse" PostBackUrl="~/registrarse.aspx"  CssClass="btn btn-outline-primary" BorderColor="#ff8000"  ForeColor="#ff8000"  runat="server">Registrarse</asp:LinkButton>
            <%-- Fin Usuario --%>
        </div>
        <%-- Fin Menu --%>
        <%-- Contenido --%>

         <div>
             <div class="col-md-6 order-md-2 mb-4" >
                 <table>
                      <tr>
                     <td>Producto:</td>

                     <td>
                         <asp:DropDownList ID="ddlProductoo" runat="server"></asp:DropDownList>
                     </td>

                     <td>
                         <asp:Button ID="Agregar2" Style="margin-top: -26px; background: #ff8000; border: #ff8000;" class="btn btn-primary" runat="server"  Text="Agregar" OnClick="Agregar2_Click" autopostback="false" />
                     </td>
                 </tr>
                 </table>      
                  <br /> 
                  <br />           
                            <h4 class="mb-3">Productos a facturar</h4>
                            <asp:GridView ID="grvListado" runat="server"
                                CssClass="table table-hover"
                                AutoGenerateColumns="false"
                                DataKeyNames="idProducto"
                                OnSelectedIndexChanged="grvListado_SelectedIndexChanged" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="900">
                                <AlternatingRowStyle BackColor="#F7F7F7"></AlternatingRowStyle>
                                <Columns>
                                  <asp:BoundField HeaderText="Código" DataField="IdProducto"/>
                                  <asp:BoundField HeaderText="Nombre" DataField="NombreProducto"/>
                                     <asp:BoundField HeaderText="Precio" DataField="PrecioProducto" DataFormatString="{0:0.00}"/>
                                  
                                     <asp:BoundField HeaderText="Impuesto" DataField="Impuesto"/>
                                    <asp:BoundField HeaderText="Estado" DataField="Estado"/>   
                                     <asp:TemplateField HeaderText="Cantidad" ItemStyle-Width="200px" >
                                        <ItemTemplate>
                                            <input type="number" max="50" min="1" style="width:50px;" />   
                                        </ItemTemplate> 
                                        </asp:TemplateField>                        
                                </Columns>
                                 <EmptyDataTemplate>
                                No hay productos en la factura!
                            </EmptyDataTemplate>
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"></FooterStyle>

                                <HeaderStyle CssClass="table-dark" BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <PagerStyle HorizontalAlign="Right" BackColor="#E7E7FF" ForeColor="#4A3C8C"></PagerStyle>

                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C"></RowStyle>

                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7"></SelectedRowStyle>

                                <SortedAscendingCellStyle BackColor="#F4F4FD"></SortedAscendingCellStyle>

                                <SortedAscendingHeaderStyle BackColor="#5A4C9D"></SortedAscendingHeaderStyle>

                                <SortedDescendingCellStyle BackColor="#D8D8F0"></SortedDescendingCellStyle>

                                <SortedDescendingHeaderStyle BackColor="#3E3277"></SortedDescendingHeaderStyle>
                            </asp:GridView>
                        </div>

                   <table style="margin-left: 155px; margin-top: 350px; border-collapse: separate;">

                 <tr>
                     <td>
                         Descuento:
                         <asp:TextBox ID="TxtDescuento" Text="" runat="server"></asp:TextBox>    
                     </td>
                     <td>
                         <asp:Button ID="BtnDescuento" Style="background: #ff8000; border: #ff8000;" class="btn btn-primary" runat="server" Text="Aplicar" OnClick="BtnDescuento_Click" />             
                     </td>
                     <td>
                         Sub Total:
                         <asp:TextBox ID="txtSubTotal" Text="" runat="server" Enabled="False" DataFormatString="{0:0.00}"></asp:TextBox>
                     </td>                  
                      <td>
                         Total:
                         <asp:TextBox ID="TxtTotal" Text="" runat="server" Enabled="False" DataFormatString="{0:0.00}"></asp:TextBox>
                     </td>
                     <td>
                         <asp:Button ID="BtnProcesarFactura" Style="background: #ff8000; border: #ff8000;" class="btn btn-primary" runat="server" Text="Facturar" OnClick="BtnProcesarFactura_Click" />
                       <br />
                     </td>
                 </tr>
                       <asp:Label ID="LblMensaje" ForeColor="blue" runat="server" Text=""></asp:Label>
             </table>
         </div>


    <!-- **** Footer Area End **** -->

    <!-- jQuery (Necessary for All JavaScript Plugins) -->
    <script src="js/jquery/jquery-2.2.4.min.js"></script>
    <!-- Popper js -->
    <script src="js/popper.min.js"></script>
    <!-- Bootstrap js -->
    <script src="js/bootstrap.min.js"></script>
    <!-- Plugins js -->
    <script src="js/plugins.js"></script>
    <!-- Active js -->
    <script src="js/active.js"></script>
        <div>
        </div>
    </form>
   
</body>
</html>