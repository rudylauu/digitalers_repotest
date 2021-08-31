<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="QuienSoy.aspx.cs" Inherits="MiPaginaPresentacion.MasInformacion.QuienSoy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <h5> ¿Quién soy?</h5>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Suspendisse potenti nullam ac tortor vitae purus faucibus ornare. Lacinia quis vel eros donec ac. Congue nisi vitae suscipit tellus mauris a. Ultrices sagittis orci a scelerisque purus. Eget aliquet nibh praesent tristique magna sit amet purus gravida. Varius quam quisque id diam vel quam elementum pulvinar etiam. Turpis cursus in hac habitasse platea dictumst. Mi bibendum neque egestas congue quisque egestas. Sed odio morbi quis commodo odio aenean sed adipiscing diam.</p>
            <p>Dictum non consectetur a erat nam at. Sit amet venenatis urna cursus eget nunc scelerisque viverra. Accumsan lacus vel facilisis volutpat est velit egestas dui. Euismod lacinia at quis risus sed. Mattis molestie a iaculis at erat pellentesque adipiscing. Lacus suspendisse faucibus interdum posuere lorem ipsum. Turpis in eu mi bibendum neque. Sit amet consectetur adipiscing elit ut aliquam purus sit. Eleifend quam adipiscing vitae proin sagittis. Velit ut tortor pretium viverra suspendisse potenti. Adipiscing tristique risus nec feugiat in fermentum. Orci eu lobortis elementum nibh.</p>
            <p>Arcu ac tortor dignissim convallis aenean et tortor. Volutpat maecenas volutpat blandit aliquam etiam erat velit scelerisque in. Amet consectetur adipiscing elit ut aliquam. In massa tempor nec feugiat nisl pretium fusce id velit. Tempor orci dapibus ultrices in iaculis nunc sed augue lacus. Sed odio morbi quis commodo. Sit amet consectetur adipiscing elit ut aliquam. Et pharetra pharetra massa massa ultricies mi. In ornare quam viverra orci sagittis eu volutpat odio facilisis. Ut aliquam purus sit amet. Tristique nulla aliquet enim tortor at. Nibh mauris cursus mattis molestie a iaculis at. Interdum velit laoreet id donec. Sed egestas egestas fringilla phasellus faucibus scelerisque eleifend donec. Sed risus pretium quam vulputate. Quis enim lobortis scelerisque fermentum dui faucibus in ornare quam. Arcu non sodales neque sodales ut etiam sit amet.</p>
        </div>
    </div>
    
    
    <hr />

    <div class="row">
        <div class="col">
                <asp:ListView runat="server" ID="lstComentarios">
                <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate> <!--todo lo que se repite-->
                    <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nombre") %></h5><!--Eval() me sirve para llamar a los objetos-->
                        <p class="card-text"><%# Eval("Texto") %></p>
                    </div>
                    </div>
                </ItemTemplate>
                </asp:ListView>
        </div>
    </div>
    <hr />

    <div class="row">
        <div class="col-8">
            <div class="form-group">
                <label>Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Comentarios</label>
                <asp:TextBox runat="server" ID="txtComentarios" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
            </div>
            <div class="form-froup">
                <%-- OnClick="btnGuardar_Click"= para disparar que cuando se haga click se dispare el evento del servidor --%>
                <asp:Button runat="server" ID="btnGuardar" Cssclass="btn btn-success" Text="Agregar comentario" OnClick="btnGuardar_Click" />

            </div>
        </div>
    </div>
</asp:Content>
