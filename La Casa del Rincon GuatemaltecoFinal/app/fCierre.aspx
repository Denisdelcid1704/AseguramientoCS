<%@ Page Title="" EnableEventValidation="false" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="fCierre.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.fCierre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h3>Terminar Venta</h3>
    <form>
        <fieldset>
            <asp:TextBox disabled ID="txtfecha" runat="server">Fecha:</asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Cliente:"></asp:Label>
            <asp:DropDownList ID="DropListcliente" runat="server" AutoPostBack="True"></asp:DropDownList>
            <asp:Label ID="Label4" runat="server" Text="Nit:"></asp:Label>
            <asp:TextBox disabled ID="txtnit" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="Tarjeta VIP:"></asp:Label>
            <asp:TextBox ID="txtvip" runat="server" style="margin-left: 12px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Forma de Pago:"></asp:Label>
             <asp:DropDownList ID="DropListpago" runat="server"></asp:DropDownList>
            <asp:LinkButton ID="lnkImprimir" CssClass="button" runat="server">Completar</asp:LinkButton>  

        </fieldset>
        <asp:Label ID="lblTotal" runat="server" Text="Total: Q 0.00"></asp:Label><hr />
        <asp:Label ID="Label3" runat="server" Text="Detalle de Compra"></asp:Label>

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
    </form>
</asp:Content>
