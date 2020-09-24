<%@Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="Creausuario.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.Creausuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Creacion de Usuarios</h3>
    <form>
        <fieldset>
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtcontraseña2" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Codigo de Seguridad"></asp:Label>
            <asp:TextBox ID="txtcodigoseg" runat="server"></asp:TextBox>
            <asp:LinkButton ID="lnkcrear" CssClass="button" runat="server">Crear</asp:LinkButton>
            <asp:LinkButton ID="lnkborrar" CssClass="button" runat="server">Borrar</asp:LinkButton>
        </fieldset>
    </form>
</asp:Content>

