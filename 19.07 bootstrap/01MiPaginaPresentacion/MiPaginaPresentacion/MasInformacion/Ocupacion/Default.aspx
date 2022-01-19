<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MiPaginaPresentacion.MasInformacion.Ocupacion.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Programo muy duro, como un esclavo....<br />
    <!-- label es para mostrar un dato en el html -->
        <h5>Contador con datos de ViewState</h5>
    <asp:Label runat="server" ID="lblContadorViewState"> 0 </asp:Label> <br />
    <asp:Button runat="server" ID="btnContarViewState" Text="Incrementar (ViewState)" CssClass="btn btn-dark" OnClick="btnContarViewState_Click" />
     
        <h5>Contador con datos de Session</h5>
    <asp:Label runat="server" ID="lblContadorSession"> 0 </asp:Label> <br />
    <asp:Button runat="server" ID="btnContarSession" Text="Incrementar (Session)" CssClass="btn btn-dark" OnClick="btnContarSession_Click" />

        <h5>Contador con datos de Cookies</h5>
    <asp:Label runat="server" ID="lblContadorCookies"> 0 </asp:Label> <br />
    <asp:Button runat="server" ID="btnContarCookies" Text="Incrementar (Cookies)" CssClass="btn btn-dark" OnClick="btnContarCookies_Click" />
</asp:Content>
