<%@ Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="devolucion.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.devolucion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Devolucion</h3>
<form>
        <fieldset>
        </fieldset>
    </form>
     <asp:GridView ID="Facturas" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="id_factura" HeaderText="Id" />
            <asp:BoundField DataField="Serie" HeaderText="Serie" />
            <asp:BoundField DataField="No" HeaderText="No" />
            <asp:BoundField DataField="estado" HeaderText="Estado" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
