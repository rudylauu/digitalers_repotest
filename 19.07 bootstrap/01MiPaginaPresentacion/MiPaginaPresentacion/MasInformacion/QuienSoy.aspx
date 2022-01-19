<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="QuienSoy.aspx.cs" Inherits="MiPaginaPresentacion.MasInformacion.QuienSoy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Visible= false : para que no se muestre a menos que se lo pidan--%>
    <asp:Panel runat="server" ID="pnlError" Visible="false" role="alert" CssClass="alert alert-danger">
        <asp:Label runat="server" ID="lblError"></asp:Label>
    </asp:Panel>
    <div class="row">
        <div class="col">
            <h5>¿Quién Soy?</h5>
            <p>
                Soy un estudiante de Ingenieria en Sistemas y recientemente culmine un cusrso de desarrollo Full Stack con .NET.
                        <br />
                Me apasiona la tecnología y sus aplicaciones. Deseo brindar y desarrollar soluciones tecnológicas, por ende busco una empresa en la que pueda poner en práctica mis conocimientos y habilidades, que se trabaje en equipo y que me permita crecer en el mundo IT.
                        <br />
                Me considero una persona resolutiva, proactiva y que trabaja en equipo, en busca de aprendizaje continuo y crecimiento profesional.
            </p>
        </div>
    </div>


    <hr />

    <div class="row">
        <div class="col">
            <asp:ListView runat="server" ID="lstComentarios">
                <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <!--todo lo que se repite-->
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nombre") %></h5>
                            <!--Eval() me sirve para llamar a los objetos-->
                            <p class="card-text"><%# Eval("Texto") %></p>
                            <a href="/MasInformacion/BorrarComentario.aspx?id=<%# Eval("Id") %>" class="btn btn-danger">Borrar</a>
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
                <asp:Button runat="server" ID="btnGuardar" CssClass="btn btn-success" Text="Agregar comentario" OnClick="btnGuardar_Click" />

            </div>
        </div>
    </div>
</asp:Content>
