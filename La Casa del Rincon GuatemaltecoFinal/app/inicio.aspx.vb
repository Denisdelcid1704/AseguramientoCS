Public Class inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtcorreo.Text = "platocanas@gmail.com"
    End Sub

    Protected Sub txtcorreo_TextChanged(sender As Object, e As EventArgs) Handles txtcorreo.TextChanged

    End Sub
End Class