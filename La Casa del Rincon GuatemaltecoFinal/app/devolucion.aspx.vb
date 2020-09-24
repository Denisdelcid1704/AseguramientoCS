Public Class devolucion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then
                mostrardatos()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub mostrardatos()
        Try

            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "Select  id_factura, serie, No, estado, facturacion.id_pedido from facturacion, Pedido where facturacion.id_pedido = pedido.id_pedido"
            Facturas.DataSource = db.ejecutarConsulta(sSql)
            Facturas.DataBind()


        Catch ex As Exception

        End Try
    End Sub
    Protected Sub Facturas_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Facturas.RowDeleting
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            Dim id As String = e.RowIndex
            Dim idfactura As String = Facturas.Rows(id).Cells(0).Text.ToString()
            sSql = "update facturacion set estado = 'anulado' where id_factura=" + idfactura
            db.ejecutarConsulta(sSql)
            sSql = "update facturacion inner join pedido on facturacion.id_pedido = pedido.id_pedido inner join detallepedido on pedido.id_pedido = detallepedido.id_pedido inner join producto on detallepedido.id_productodetalle = producto.id_producto  set producto.existencia = producto.existencia + detallepedido.cantidad where facturacion.id_factura =" + idfactura
            db.ejecutarConsulta(sSql)
            mostrardatos()
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Factura Anulada correctamente e Inventario Actualizado')", True)

        Catch ex As Exception

        End Try
    End Sub
End Class