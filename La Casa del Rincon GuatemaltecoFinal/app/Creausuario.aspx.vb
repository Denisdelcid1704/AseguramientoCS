Public Class Creausuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then

            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub lnkcrear_Click(sender As Object, e As EventArgs) Handles lnkcrear.Click
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "insert into login(Usuario, Contraseña, Codseguridad) values('" +
                txtusuario.Text.ToString() + "','" +
                txtcontraseña2.Text.ToString() + "','" + txtcodigoseg.Text.ToString() + "')"
            db.ejecutarConsulta(sSql)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Usuario Ingresado con Exito...')", True)
        Catch ex As Exception
            Throw ex
            ' Si lanza una excepcion no proceso la consulta
        End Try
    End Sub

    Protected Sub lnkborrar_Click(sender As Object, e As EventArgs) Handles lnkborrar.Click
        txtusuario.Text = ""
        txtcontraseña2.Text = " "
        txtcodigoseg.Text = " "


    End Sub
End Class