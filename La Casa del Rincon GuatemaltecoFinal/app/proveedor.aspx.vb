Public Class proveedor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then
                MostrarDatos()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub MostrarDatos()
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "select * from Proveedor order by idproveedor Desc limit 10"
            Registros.DataSource = db.ejecutarConsulta(sSql)
            Registros.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub lnkGuardar_Click(sender As Object, e As EventArgs) Handles lnkGuardar.Click
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "insert into proveedor(nom_proveedor, dir_proveedor, tel_proveedor) values('" +
                txtNombres.Text.ToString() + "','" +
                txtDireccion.Text.ToString() + "','" +
                txttelefono.Text.ToString() + "')"
            'ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('script: " + sSql + "')", True)
            db.ejecutarConsulta(sSql)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Ingresado con Exito...')", True)
            MostrarDatos()
        Catch ex As Exception
            Throw ex
            ' Si lanza una excepcion no proceso la consulta
        End Try
    End Sub
    Protected Sub Registros_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Registros.RowDeleting
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            Dim id As String = e.RowIndex
            Dim idproveedor As String = Registros.Rows(id).Cells(0).Text.ToString()
            sSql = "Delete from Proveedor where idproveedor=" + idproveedor
            db.ejecutarConsulta(sSql)
            MostrarDatos()
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Proveedor eliminado correctamente')", True)

        Catch ex As Exception

        End Try
    End Sub

End Class