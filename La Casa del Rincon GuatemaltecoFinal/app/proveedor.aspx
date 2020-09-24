<%@ Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="proveedor.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.proveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Proveedores</h3>
    <form>
        <fieldset>
            <asp:Label ID="Label1" runat="server" Text="Nombres:"></asp:Label>
            <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Direccion:"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Telefono:"></asp:Label>
            <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            <asp:LinkButton ID="lnkGuardar" CssClass="button" runat="server">Guardar</asp:LinkButton>
        </fieldset>
    </form>
    <asp:GridView ID="Registros" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="idproveedor" HeaderText="Id" />
            <asp:BoundField DataField="nom_Proveedor" HeaderText="Nombre" />
            <asp:BoundField DataField="dir_proveedor" HeaderText="Direccion" />
            <asp:BoundField DataField="tel_proveedor" HeaderText="Telefono" />
             <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
