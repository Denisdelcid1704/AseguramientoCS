<%@ Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="productos.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Productos</h3>
<form>

        <fieldset>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Departemento:"></asp:Label>
            <asp:TextBox ID="txtDepartamento" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Precio:"></asp:Label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Existencia:"></asp:Label>
            <asp:TextBox ID="txtExistencia" runat="server"></asp:TextBox><asp:Label ID="Label5" runat="server" Text="Proveedor:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:LinkButton ID="lnkGuardar" CssClass="button" runat="server">Guardar</asp:LinkButton> <asp:LinkButton ID="Linknuevo" CssClass="button" runat="server">Nuevo Producto</asp:LinkButton>
        </fieldset>
    </form>
    
    <asp:GridView ID="Registros" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="id_producto" HeaderText="Id" />
            <asp:BoundField DataField="nom_producto" HeaderText="Nombre" />
            <asp:BoundField DataField="Departamento" HeaderText="Depto" />
            <asp:BoundField DataField="precio_venta" HeaderText="Precio" />
            <asp:BoundField DataField="Existencia" HeaderText="Stock" />
            <asp:BoundField DataField="nom_proveedor" HeaderText="Proveedor" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
