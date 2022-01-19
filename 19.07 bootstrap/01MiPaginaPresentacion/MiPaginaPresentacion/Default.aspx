<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MiPaginaPresentacion.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-10"> <%--medidas de las culumnas--%> 

            <div class="row">

                <div class="col">
                    <h5>¿Quien soy?</h5>
                    <p>
                        Soy un estudiante de Ingenieria en Sistemas y recientemente culmine un cusrso de desarrollo Full Stack con .NET.
                        <br />
                        Me apasiona la tecnología y sus aplicaciones. Deseo brindar y desarrollar soluciones tecnológicas, por ende busco una empresa en la que pueda poner en práctica mis conocimientos y habilidades, que se trabaje en equipo y que me permita crecer en el mundo IT.
                        <br />
                        Me considero una persona resolutiva, proactiva y que trabaja en equipo, en busca de aprendizaje continuo y crecimiento profesional.
                    </p>
                    <%--<a href="MasInformacion/QuienSoy.aspx" class="btn btn-dark">Leer más</a>--%>
                    <asp:Button runat="server" ID="btnRedirigirQuienSoy" Text="Leer más" Cssclass="btn btn-dark" OnClick="btnRedirigirQuienSoy_Click" />
                    </div>
                    <div class="col">
                        <h5>A que me dedico?</h5>
                        <p>Sed libero enim sed faucibus turpis in eu mi bibendum. Sagittis orci a scelerisque purus semper. Cras adipiscing enim eu turpis egestas pretium aenean pharetra magna. Pellentesque eu tincidunt tortor aliquam nulla facilisi cras fermentum odio. Ut placerat orci nulla pellentesque dignissim enim sit amet. Elit ut aliquam purus sit amet luctus venenatis lectus. Gravida in fermentum et sollicitudin ac orci phasellus egestas. Felis imperdiet proin fermentum leo vel orci. Tortor at risus viverra adipiscing at in tellus integer. Etiam tempor orci eu lobortis elementum nibh. Amet commodo nulla facilisi nullam vehicula. Cursus risus at ultrices mi tempus imperdiet nulla malesuada. Bibendum enim facilisis gravida neque convallis a cras. Dictumst quisque sagittis purus sit.</p>
                        <a href="MasInformacion/Ocupacion/Default.aspx" class="btn btn-dark">Leer más</a>
                    </div>

                </div>
           
            </div>
         <div class="col-md-2">
            <!--columna -->
            <image class="img-fluid" src="imagen/rudy.jpg" />

        </div>
        </div>
        
    
    <div class="row">
        <!--fila  -->
        <div class="col">
            <!--columna -->
            <h5>EXPERIENCIA </h5>
            <p></p>
            <p></p>
            <asp:Button runat="server" Text="Leer Más" CssClass="btn btn-dark" />
        </div>
        <div class="col">
            <h5>PRPYECTOS PERSONALES</h5>
            <asp:ListView runat="server" ID="lstProyectos">
                <LayoutTemplate>
                    <!-- es lo que rodea a lo que se repite -->
                    <ul>
                        <!-- el ID siempre es itemPlaceHolder -->
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                    </ul>
                </LayoutTemplate>
                <ItemTemplate>
                    <!-- lo que se repite-->
                    <li>
                        <!--cada uno del los elementos del ListView sera el DataItem -->
                        <!-- siempre se escribe de esta forma-->
                        <%# Container.DataItem %>
                        <!--solo se utiliza cuando tenemmos una lista de tipo primitivo int,string etc.-->
                    </li>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>

</asp:Content>
