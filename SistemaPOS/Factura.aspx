<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Factura.aspx.cs" Inherits="SistemaPOS.Factura" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="description" content=""/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>Factura</title>
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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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

        <div class="cuadrado">
            <h3 class="mb-3" style="color: white; font-size: 35px; margin-left: 520px;">Sistema POS Facturación</h3>
        </div>
        <style>
            .cuadrado {
                padding: 20px;
                margin: 5px;
                background-color: #ff8000;
                border: solid 1px #ff8000;
                color: white;
            }
        </style>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

             <div style="margin-left: 155px; margin-top: -220px;">
                  <table>
                      <tr>
                     <td>Nombre del cliente:</td>
                     <td>
                         <asp:TextBox ID="txtNombreCliente" runat="server"></asp:TextBox>
                     </td>
                     
                 </tr>
                 </table>            
                  <br /> 
                  <br />           
                            <h4 class="mb-3">Factura</h4>

            <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

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
                                     <asp:TemplateField HeaderText="Cantidad" ItemStyle-Width="100px" >
                                       <ItemTemplate>
                                            <asp:TextBox
                                                ID="CantidadComprar"
                                                Width="40"
                                                Text="1"
                                                runat="server"
                                                OnTextChanged="CantidadComprar_TextChanged"
                                                AutoPostBack="true"></asp:TextBox>
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
                <br /> 
                <br /> 
                      </ContentTemplate>
                      </asp:UpdatePanel>
                     </div>

                   <table style="margin-left: 155px; margin-top: 160px; border-collapse: separate;">
                 <tr>               
                      <td>
                         Total:
                         <asp:TextBox ID="TxtTotal" Text="" runat="server" Enabled="False" DataFormatString="{0:0.00}"></asp:TextBox>
                     </td>
                     
                 </tr>
             </table>

        <table style="margin-left: 155px; margin-top: 30px; border-collapse: separate;">
            <tr>

                <td>Forma de Pago:
                           <asp:DropDownList ID="ddlFormaPago" Style="width: 130px; height: 30px;" runat="server"></asp:DropDownList>
                </td>
            </tr>
        </table>
         <table style="margin-left: 155px; margin-top: 30px; border-collapse: separate;">
            <tr>
                <td>Cliente paga con:
                    <asp:TextBox ID="txtMontoCliente" runat="server"></asp:TextBox>       
                </td>
            </tr>
        </table>
         <table style="margin-left: 155px; margin-top: 30px; border-collapse: separate;">
            <tr>
                <td>Vuelto:
                    <asp:TextBox ID="txtVuelto" runat="server"></asp:TextBox>       
                </td>
            </tr>
        </table>
          <table style="margin-left: 155px; margin-top: 30px; border-collapse: separate;">
            <tr>
                <td>Número de tarjeta:
                    <asp:TextBox ID="txtNúmero" runat="server"></asp:TextBox>       
                </td>
            </tr>
        </table>
         <table style="margin-left: 300px; margin-top: 30px; border-collapse: separate;">
            <tr>
               <asp:Button ID="btnProcesar" Style="background: #ff8000; margin-left: 155px; margin-top: 50px;border: #ff8000;" class="btn btn-primary" runat="server" Text="Procesar Factura" OnClick="btnProcesar_Click" autopostback="false" />
            </tr>
        </table>
         <table style="margin-left: 300px; margin-top: 30px; border-collapse: separate;">
            <tr>
               <asp:Button ID="btnCalcularVuelto" Style="background: #ff8000; margin-left: 520px; margin-top: -545px;border: #ff8000;" class="btn btn-primary" runat="server" Text="Calcular Vuelto" OnClick="btnCalcularVuelto_Click" autopostback="false" />
            </tr>
        </table>
        <br /> 
        <br /> 
        <br /> 
        <br />
        <br /> 
        <br />
          
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