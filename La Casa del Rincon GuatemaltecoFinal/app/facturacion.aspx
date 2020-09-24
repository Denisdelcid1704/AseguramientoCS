<%@ Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="facturacion.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.facturacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Detalle de Pedido</h3>
        <fieldset>
            <asp:Label ID="Label4" runat="server" Text="Producto:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Cantidad"></asp:Label><asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
            <asp:LinkButton ID="lnkagregar" CssClass="button" runat="server">Agregar</asp:LinkButton>
        </fieldset>
    <asp:LinkButton CssClass="button button-outline" ID="LinkButton1" runat="server">Cancelar Pedido</asp:LinkButton>
    <asp:LinkButton CssClass="button button-outline" ID="Facturar" runat="server">Facturar</asp:LinkButton>
    <asp:LinkButton CssClass="button button-outline" ID="Lknbotonvalida" runat="server">Validar Existencia</asp:LinkButton>

    <br />
    <asp:Label ID="lblTotal" runat="server" Text="Total: Q 0.00"></asp:Label>
    
    <asp:GridView ID="Registros" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="idproducto" HeaderText="Id" />
            <asp:BoundField DataField="Descripcion" HeaderText="Nombre" />
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
            <asp:BoundField DataField="precio_venta" HeaderText="Precio" />
            <asp:BoundField DataField="subtotal" HeaderText="Subtotal" />

            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
