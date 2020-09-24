Public Class existencia
    Inherits System.Web.UI.Page
    Private Sub Mostrarproductos()
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "select * from Producto"
            Stock.DataSource = db.ejecutarConsulta(sSql)
            Stock.DataBind()
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then
                Mostrarproductos()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class