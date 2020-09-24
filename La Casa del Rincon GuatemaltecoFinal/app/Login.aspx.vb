Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Accesar_Click(sender As Object, e As EventArgs) Handles Accesar.Click
        If (Existeusuario(textusuario.Text, textcontraseña.Text)) Then
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Usuario Valido')", True)
            Server.Transfer("/app/inicio.aspx", True)
        Else
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Usuario Invalido')", True)

        End If
    End Sub

    Function Existeusuario(ByVal usuario As String, ByVal contraseña As String) As Boolean

        Dim db As New MysqlDB
        Dim sSql As String
        Dim res As New DataTable

        sSql = "SELECT * FROM login where Usuario = '" & usuario & "' and password = '" & contraseña & "'"
        res = db.ejecutarConsulta(sSql)
        If (res.Rows.Count = 1) Then
            Return True
        Else
            Return False
        End If

    End Function


    Protected Sub Recucontra_Click(sender As Object, e As EventArgs) Handles Recucontra.Click
        Server.Transfer("/app/valida.aspx", True)
    End Sub
End Class