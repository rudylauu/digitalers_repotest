     <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MiPaginaPresentacion.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-8">
            
            <div class="row">
                <div class="col">
                    <image class="img-fluid" src="imagen/myAvatar.png"/>
                </div>
                <div class="col">
                    <h5>¿Quien soy?</h5>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ultricies mi eget mauris pharetra et ultrices neque. Arcu non sodales neque sodales. Non arcu risus quis varius quam. Semper auctor neque vitae tempus quam pellentesque nec. Id diam maecenas ultricies mi eget mauris pharetra et. Sed arcu non odio euismod lacinia at quis risus. Eros in cursus turpis massa tincidunt dui. Habitant morbi tristique senectus et. Porttitor lacus luctus accumsan tortor posuere ac ut consequat. Nec feugiat nisl pretium fusce id velit ut. Magna fringilla urna porttitor rhoncus dolor purus. Vivamus at augue eget arcu dictum varius duis at consectetur. Egestas sed sed risus pretium quam. Hac habitasse platea dictumst vestibulum rhoncus est pellentesque elit ullamcorper. Elementum nisi quis eleifend quam. Aliquam nulla facilisi cras fermentum odio eu. Tellus at urna condimentum mattis pellentesque. Tortor consequat id porta nibh venenatis cras sed.</p>
                    <%--<a href="MasInformacion/QuienSoy.aspx" class="btn btn-dark">Leer más</a>--%>
                    <asp:Button runat="server" ID="btnRedirigirQuienSoy" Text="Leer más" Cssclas="btn btn-dark" OnClick="btnRedirigirQuienSoy_Click" />
                </div>
            </div>
        </div>
        <div class="col-md-4"> <!--columna -->
            <h5>A que me dedico?</h5>
            <p>Sed libero enim sed faucibus turpis in eu mi bibendum. Sagittis orci a scelerisque purus semper. Cras adipiscing enim eu turpis egestas pretium aenean pharetra magna. Pellentesque eu tincidunt tortor aliquam nulla facilisi cras fermentum odio. Ut placerat orci nulla pellentesque dignissim enim sit amet. Elit ut aliquam purus sit amet luctus venenatis lectus. Gravida in fermentum et sollicitudin ac orci phasellus egestas. Felis imperdiet proin fermentum leo vel orci. Tortor at risus viverra adipiscing at in tellus integer. Etiam tempor orci eu lobortis elementum nibh. Amet commodo nulla facilisi nullam vehicula. Cursus risus at ultrices mi tempus imperdiet nulla malesuada. Bibendum enim facilisis gravida neque convallis a cras. Dictumst quisque sagittis purus sit.</p>
        <a href="MasInformacion/Ocupacion/Default.aspx" class="btn btn-dark">Leer más</a>
        </div>
    </div>
    <div class="row"> <!--fila  -->
        <div class="col"> <!--columna -->
            <h5>Que experiencia tengo </h5>
            <p>Mattis enim ut tellus elementum sagittis vitae. Turpis egestas pretium aenean pharetra magna ac. Ultricies lacus sed turpis tincidunt id. Quis hendrerit dolor magna eget est lorem. Eget magna fermentum iaculis eu. Nulla at volutpat diam ut. Lectus arcu bibendum at varius vel pharetra vel turpis. Arcu bibendum at varius vel pharetra. Sed enim ut sem viverra aliquet eget sit amet tellus. In nisl nisi scelerisque eu.</p>
            <p> Scelerisque eu ultrices vitae auctor eu augue ut lectus. Vulputate enim nulla aliquet porttitor lacus luctus. Nec feugiat in fermentum posuere urna. Mauris vitae ultricies leo integer malesuada nunc vel. Eget duis at tellus at. Ut tellus elementum sagittis vitae et leo duis. Non sodales neque sodales ut etiam sit amet nisl. Diam donec adipiscing tristique risus nec feugiat in. Consectetur lorem donec massa sapien faucibus et. Amet mattis vulputate enim nulla.</p>
            <asp:Button runat="server" Text="Leer Más" CssClass="btn btn-dark" />
        </div>
        <div class="col">
            <h5>En que proyectos participe?</h5>
            <asp:ListView runat="server" ID="lstProyectos">
                <LayoutTemplate><!-- es lo que rodea a lo que se repite -->
                    <ul> <!-- el ID siempre es itemPlaceHolder -->
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                    </ul>
                </LayoutTemplate>
                <ItemTemplate> <!-- lo que se repite-->
                    <li><!--cada uno del los elementos del ListView sera el DataItem -->
                        <!-- siempre se escribe de esta forma-->
                        <%# Container.DataItem %> <!--solo se utiliza cuando tenemmos una lista de tipo primitivo int,string etc.-->
                    </li>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
    
    </asp:Content>
