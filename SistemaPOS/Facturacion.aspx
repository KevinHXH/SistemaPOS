<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="SistemaPOS.Facturacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="description" content=""/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>ExpeMedical-Inicio</title>
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

        <section class="breadcumb-area bg-img gradient-background-overlay" style="background-image: url(img/bg-img/hero6.jpg);">
            <div class="container h-100">
                <div class="row h-100 align-items-center">
                    <div class="col-12">
                        <div class="breadcumb-content">
                            <!-- Title -->
                            <h3 class="breadcumb-title">Sistema POS de Facturación</h3>
                            <!-- Breadcumb -->
                           
                        </div>
                    </div>
                </div>
            </div>
        </section>
         <br />
         <br />
         <br />
         <br />
        
         

         <div class="col-md-6 order-md-2 mb-4" style="margin-left:140px;">
                       
                       
                       
                    </div>
             <br />
             <br />
             <br />
             <br />
             <br />



             <table style="margin-left: 155px; margin-top: -360px; border-collapse: separate;">

                 <tr>

                     <td>Producto:</td>

                     <td>
                         <asp:DropDownList ID="ddlProductoo" Style="width: 130px;" class="form-control" runat="server" OnSelectedIndexChanged="ddlProductoo_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                     </td>

                     <td>
                         <asp:Button ID="Agregar2" Style="margin-top: -26px; background: #ff8000; border: #ff8000;" class="btn btn-primary" runat="server" Text="Agregar" OnClick="Agregar2_Click" />
                     </td>

                 </tr>

             </table>



             <div class="col-md-6 order-md-2 mb-4" >
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
                                     <asp:BoundField HeaderText="Precio" DataField="PrecioProducto"/>
                                    <asp:BoundField HeaderText="Precio" DataField="PrecioProducto"/>
                                     <asp:BoundField HeaderText="Impuesto" DataField="Impuesto"/>
                                    <asp:BoundField HeaderText="Estado" DataField="Estado"/>
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

                  
                                   
                                     









































         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />


         </div>


















       
            <footer class="footer-area">
        <!-- Main Footer Area -->
        <div class="main-footer-area section_padding_100 bg-default">
            <div class="container" style="margin-left:330px;">
                <div class="row">
                    <div class="col-12 col-sm-6 col-xl-3">
                        <div class="footer-widget-area">
                            <div class="footer-logo">
                               
                            </div>
                            <p>ExpeMedical CR, tú mejor opción de expediente digital</p>
                            <div class="footer-social-info">
                                <a href="#" data-toggle="tooltip" data-placement="top" title="Pinterest"><i class="fa fa-pinterest" aria-hidden="true"></i></a>
                                <a href="#" data-toggle="tooltip" data-placement="top" title="Facebook"><i class="fa fa-facebook" aria-hidden="true"></i></a>
                                <a href="#" data-toggle="tooltip" data-placement="top" title="Twitter"><i class="fa fa-twitter" aria-hidden="true"></i></a>
                                <a href="#" data-toggle="tooltip" data-placement="top" title="Dribbble"><i class="fa fa-dribbble" aria-hidden="true"></i></a>
                                <a href="#" data-toggle="tooltip" data-placement="top" title="Behance"><i class="fa fa-behance" aria-hidden="true"></i></a>
                                <a href="#" data-toggle="tooltip" data-placement="top" title="Linkedin"><i class="fa fa-linkedin" aria-hidden="true"></i></a>
                            </div>
                        </div>
                    </div>
                    <div class="col-12 col-sm-6 col-xl-3">
                        <div class="footer-widget-area">
                            <div class="widget-title">
                                <h6>Últimas noticias</h6>
                            </div>
                            <div class="widget-blog-post">
                                <!-- Single Blog Post -->
                                <div class="widget-single-blog-post d-flex">
                                    <div class="widget-post-thumbnail pr-2">
                                        
                                    </div>
                                    <div class="widget-post-content">
                                        <a href="#">Un gran descubrimiento para la medicina</a>
                                        <p>Dic 02, 2017</p>
                                    </div>
                                </div>             
                                <div class="widget-single-blog-post d-flex">
                                    <div class="widget-post-thumbnail pr-2">
                                        
                                    </div>
                                    <div class="widget-post-content">
                                        <a href="#">Información sobre Pastillas</a>
                                        <p>Nov 03, 2017</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>  
                    <div class="col-12 col-sm-6 col-xl-3">
                        <div class="footer-widget-area">
                            <div class="widget-title">
                                <h6>Contáctanos</h6>
                            </div>

                            <div class="widget-contact">
                                <!-- Single Contact Info -->
                                <div class="widget-single-contact d-flex align-items-center">
                                    <div class="widget-contact-thumbnail mr-15">
                                        
                                    </div>
                                    <div class="widget-contact-info">
                                         <p>Lunes - Viernes 5:30 am - 6:00 pm <br/> Sábado y Domingo - Fuera de Servicio</p>
                                    </div>
                                </div>
                                <!-- Single Contact Info -->
                                <div class="widget-single-contact d-flex align-items-center">
                                    <div class="widget-contact-thumbnail mr-15">
                                       
                                    </div>
                                    <div class="widget-contact-info">
                                         <p>Alajuela, Costa Rica <br/> 20102 San Antonio</p>
                                    </div>
                                </div>
                                <!-- Single Contact Info -->
                                <div class="widget-single-contact d-flex align-items-center">
                                    <div class="widget-contact-thumbnail mr-15">
                                        
                                    </div>
                                    <div class="widget-contact-info">
                                         <p>2442 0898<br/> ExpeMedicalCR@gmail.com</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Bottom Footer Area -->
        <div class="bottom-footer-area">
            <div class="container h-100">
                <div class="row h-100">
                    <div class="col-12 h-100">
                        <div class="bottom-footer-content h-100 d-md-flex align-items-center justify-content-between">
                            <!-- Copywrite Text -->
                            <div class="copywrite-text">
                                <p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
Copyright &copy;<script>document.write(new Date().getFullYear());</script> Todos los derechos reservados
<!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
</p>
                            </div>
                            <!-- Footer Menu -->
                            <div class="footer-menu">
                                <nav>
                                    <ul>
                                        <li><a href="#">Inicio</a></li>
                                        <li><a href="#">Sobre nosotros</a></li>
                                        <li><a href="#">Doctores</a></li>
                                        <li><a href="#">Servicios</a></li>
                                        <li><a href="#">Contacto</a></li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
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