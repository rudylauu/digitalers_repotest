<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MiProyecto01.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <%// aqui es para escribir codigo c#
                int i = 100; Response.Write(i);
            %>
            <br /> 
            <asp:label runat="server" ID="lblSaludo"> </asp:label>
            <asp:Label runat="server" ID="lblConfidencial"> mi TC es 1234564521</asp:Label>
            
            <hr />
            <asp:TextBox runat="server" ID="txtNombre"> </asp:TextBox><br />
            <asp:Button runat="server" ID="btnSaludar" Text="Saludar" OnClick="btnSaludar_Click"/>
            <asp:Label runat="server" ID="lblSaludarPersona"></asp:Label>
        </div>
    </form>
</body>
</html>
