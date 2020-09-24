<%@ Page EnableEventValidation="false"  Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="clientes.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Todos los formularios son esta forma, aqui se agrega el codigo -->
    <h3>Clientes</h3>
    <form>
        <fieldset>
            <asp:Label ID="Label1" runat="server" Text="Nombres:"></asp:Label>
            <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Apellidos:"></asp:Label>
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="No. de Nit:"></asp:Label>
            <asp:TextBox ID="txtnit" runat="server"></asp:TextBox>
            <asp:LinkButton ID="lnkGuardar" CssClass="button" runat="server">Guardar</asp:LinkButton>
        </fieldset>
    </form>
    <asp:GridView ID="Registros" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="id_cliente" HeaderText="Id" />
            <asp:BoundField DataField="nombre_cliente" HeaderText="Nombre" />
            <asp:BoundField DataField="apellido_cliente" HeaderText="Apellido" />
            <asp:BoundField DataField="nit" HeaderText="Nit" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
