Public Class clientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then
                MostrarDatos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub lnkGuardar_Click(sender As Object, e As EventArgs) Handles lnkGuardar.Click
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "insert into cliente(nombre_cliente, apellido_cliente, status_cliente, nit) values('" +
                txtNombres.Text.ToString() + "','" +
                txtApellidos.Text.ToString() + "','" +
                "N" + "','" + txtnit.Text + "')"
            db.ejecutarConsulta(sSql)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Cliente Ingresado con Exito...')", True)
            MostrarDatos()
        Catch ex As Exception
            Throw ex
            ' Si lanza una excepcion no proceso la consulta
        End Try


    End Sub
    Private Sub MostrarDatos()
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "select * from cliente order by id_cliente Desc limit 10"
            Registros.DataSource = db.ejecutarConsulta(sSql)
            Registros.DataBind()
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub Registros_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Registros.RowDeleting
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            Dim id As String = e.RowIndex
            Dim idcliente As String = Registros.Rows(id).Cells(0).Text.ToString()
            sSql = "Delete from Cliente where id_cliente=" + idcliente
            db.ejecutarConsulta(sSql)
            MostrarDatos()
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Cliente eliminado correctamente')", True)

        Catch ex As Exception

        End Try
    End Sub
End Class