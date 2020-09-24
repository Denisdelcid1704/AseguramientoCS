
Public Class valida
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then

            End If
        Catch ex As Exception

        End Try
    End Sub
    Function Existeusuario(ByVal usuario As String, ByVal Codseguridad As String) As Boolean

        Dim db As New MysqlDB
        Dim sSql As String
        Dim res As New DataTable

        sSql = "SELECT * FROM login where Usuario = '" & usuario & "' and Codseguridad = '" & Codseguridad & "'"
        res = db.ejecutarConsulta(sSql)
        If (res.Rows.Count = 1) Then
            Return True
        Else
            Return False
        End If

    End Function
    Protected Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        txtuser.Text = ""
        txtcod.Text = ""


    End Sub

    Protected Sub regresarlogin_Click(sender As Object, e As EventArgs) Handles regresarlogin.Click
        Server.Transfer("/app/Login.aspx", True)
    End Sub

    Protected Sub Validar_Click(sender As Object, e As EventArgs) Handles Validar.Click
        If (Existeusuario(txtuser.Text, txtcod.Text)) Then
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Usuario Valido')", True)
            mostrarusuarios()
        Else
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Usuario Invalido')", True)

        End If
    End Sub
    Private Sub mostrarusuarios()
        Try

            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "SELECT * FROM login where Codseguridad= " + txtcod.Text
            Usuarios.DataSource = db.ejecutarConsulta(sSql)
            Usuarios.DataBind()
        Catch ex As Exception

        End Try
    End Sub
End Class