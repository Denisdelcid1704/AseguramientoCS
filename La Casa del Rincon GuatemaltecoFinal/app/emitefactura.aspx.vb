Public Class emitefactura
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then
                txtidpedido.Text = Session("id_ultimopedido").ToString()
                MostrarDatos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub lnkemitir_Click(sender As Object, e As EventArgs) Handles lnkemitir.Click
        Try
            Dim db As New MysqlDB
            Dim sSql As String
            txtSerie.Text = "A"
            sSql = "insert into Facturacion(Serie, estado, id_pedido) values('" + txtSerie.Text.ToString() + "','" + "Emitida" + "','" + txtidpedido.Text + "');update Facturacion set No = last_insert_id() where id_factura = last_insert_id();"
            db.ejecutarConsulta(sSql)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Factura Emitida con exito')", True)
            MostrarDatos()
            Session("id_ultimopedido") = Nothing
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub MostrarDatos()
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "select * from Facturacion order by id_factura "
            Registros.DataSource = db.ejecutarConsulta(sSql)
            Registros.DataBind()
        Catch ex As Exception

        End Try
    End Sub
End Class