<%@ Page EnableEventValidation="false" Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/app/masterPage/App.Master" CodeBehind="Reportes.aspx.vb" Inherits="La_Casa_del_Rincon_GuatemaltecoFinal.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Reporte de Ventas</h4>
 <form>
     </form>
     <asp:GridView ID="Registros" runat="server" AutoGenerateColumns="False" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="id_producto" HeaderText="Id" />
            <asp:BoundField DataField="nom_producto" HeaderText="Nombre" />
            <asp:BoundField DataField="Departamento" HeaderText="Depto" />
            <asp:BoundField DataField="precio_venta" HeaderText="Precio" />
            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
            <asp:BoundField DataField="Total_Ingreso" HeaderText="Total_Ingreso" />
        </Columns>
    </asp:GridView>
</asp:Content>
