<%@ Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="emitefactura.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.emitefactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Emitir Factura</h3>
    <form>
        <fieldset>
                <asp:Label ID="Label1" runat="server" Text="Serie:"></asp:Label>
            <asp:TextBox ID="txtSerie" runat="server" Enabled="False"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Numero Pedido:"></asp:Label>
           <asp:TextBox ID="txtidpedido" runat="server" Enabled="False"></asp:TextBox>
            <asp:LinkButton ID="lnkemitir" CssClass="button" runat="server">Emitir</asp:LinkButton>  

        </fieldset>
        </form>
        <asp:GridView ID="Registros" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="id_factura" HeaderText="Id" />
            <asp:BoundField DataField="Serie" HeaderText="Serie" />
            <asp:BoundField DataField="No" HeaderText="Numero" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
