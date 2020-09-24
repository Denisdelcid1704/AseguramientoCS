<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="valida.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.valida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../../Content/milligram.min.css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="container">
         <h2>Recuperacion de Contraseña</h2>
  <fieldset>
      <asp:Label ID="lblusu" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtuser" runat="server" style="margin-left: 11px"></asp:TextBox>
      <asp:Label ID="Lblcodva" runat="server" Text="Codigo Validacion"></asp:Label>
        <asp:TextBox type= "password" ID="txtcod" runat="server" style="margin-left: 11px"></asp:TextBox>
      <asp:LinkButton ID="Validar" CssClass="button" runat="server">Validar</asp:LinkButton>
      <asp:LinkButton ID="borrar" CssClass="button" runat="server">Borrar</asp:LinkButton>
      <asp:LinkButton ID="regresarlogin" CssClass="button" runat="server">Go Login</asp:LinkButton>
      </fieldset>
    </div>
    
     <asp:GridView ID="Usuarios" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:CommandField ShowDeleteButton="true" />
            <asp:BoundField DataField="Id_login" HeaderText="Id" />
            <asp:BoundField DataField="Usuario" HeaderText="User" />
            <asp:BoundField DataField="password" HeaderText="Password" />
            <asp:BoundField DataField="Codseguridad" HeaderText="Codigo recuperacion" />
        </Columns>
    </asp:GridView>
        </form>
</body>
</html>
