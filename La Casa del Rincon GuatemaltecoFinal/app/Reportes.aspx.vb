Public Class Reportes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then
                MostrarDatos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Facturar_Click(sender As Object, e As EventArgs)
        MostrarDatos()
    End Sub
    Private Sub MostrarDatos()
        Try
           
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "Select producto.id_producto,producto.nom_producto,producto.departamento,producto.precio_venta,detalleproducto.cantidad, (producto.precio_venta *detalleproducto.cantidad) as Total_Ingreso from Producto as producto , DetallePedido as detalleproducto where producto.id_producto = detalleproducto.id_productodetalle"
            Registros.DataSource = db.ejecutarConsulta(sSql)
            Registros.DataBind()
            

        Catch ex As Exception

        End Try
    End Sub
End Class