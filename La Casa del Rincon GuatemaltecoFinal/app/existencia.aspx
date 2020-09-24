<%@ Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="existencia.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.existencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Stock de Productos</h3>
      <form>
        <fieldset>
             </fieldset>
    </form>
    <asp:GridView ID="Stock" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="id_producto" HeaderText="Id" />
            <asp:BoundField DataField="nom_producto" HeaderText="Nombre" />
            <asp:BoundField DataField="departamento" HeaderText="Departamento" />
            <asp:BoundField DataField="Existencia" HeaderText="Existencia" />
            <asp:CommandField ShowDeleteButton="false" />
        </Columns>
    </asp:GridView>
</asp:Content>
