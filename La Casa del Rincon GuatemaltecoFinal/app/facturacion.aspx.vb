Public Class facturacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cargarTablaTemporal()
            If (Not IsPostBack) Then

                CargarProducto()
                MostrarDatos()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub cargarTablaTemporal()
        Try
            If Session("detalle") Is Nothing Then
                Dim dt As DataTable = New DataTable("detalle")
                dt.Columns.Add(New DataColumn("idproducto", Type.GetType("System.String")))
                dt.Columns.Add(New DataColumn("Descripcion", Type.GetType("System.String")))
                dt.Columns.Add(New DataColumn("Cantidad", Type.GetType("System.String")))
                dt.Columns.Add(New DataColumn("Precio_Venta", Type.GetType("System.String")))
                dt.Columns.Add(New DataColumn("Subtotal", Type.GetType("System.String")))
                Session("detalle") = dt
                'MostrarDatos()
                'ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Cargado...')", True)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargarProducto()
        Try
            Dim db As New MysqlDB
            Dim sSql As String
            Dim dt As New DataTable

            sSql = "Select id_producto,concat(nom_producto,' | Q.',precio_venta) as nom_producto from Producto"
            dt = db.ejecutarConsulta(sSql)
            For Each Row As DataRow In dt.Rows
                DropDownList1.Items.Add(
                    New ListItem(Row("nom_producto").ToString(),
                                 Row("id_producto").ToString()
                                 ))
            Next
        Catch ex As Exception

        End Try

    End Sub
    Protected Sub lnkagregar_Click(sender As Object, e As EventArgs) Handles lnkagregar.Click
        Try
            Dim idp As String = DropDownList1.SelectedValue.ToString
            Dim cp As String = txtcantidad.Text
            Dim dt As DataTable = Session("detalle")
            Dim nr As DataRow = dt.NewRow
            Dim db As New MysqlDB

            Dim dtProducto As DataTable = db.ejecutarConsulta("SELECT * FROM PRODUCTO WHERE ID_PRODUCTO = " + idp)
            nr("idproducto") = idp
            nr("Descripcion") = dtProducto.Rows(0)("nom_producto")
            nr("Cantidad") = txtcantidad.Text.ToString
            nr("Precio_Venta") = dtProducto.Rows(0)("precio_venta")
            nr("Subtotal") = Int32.Parse(nr("Precio_Venta").ToString()) * Int32.Parse(nr("Cantidad").ToString())

            dt.Rows.Add(nr)
            Session("detalle") = dt
            MostrarDatos()

        Catch ex As Exception
            Throw ex
            ' Si lanza una excepcion no proceso la consulta
        End Try
    End Sub
    Private Sub MostrarDatos()
        Try
            Dim total As New Double
            total = 0
            Dim dt As DataTable = Session("detalle")
            For Each row As DataRow In dt.Rows
                total = total + Double.Parse(row("Subtotal"))
            Next
            lblTotal.Text = "Total: Q. " + total.ToString()

            Registros.DataSource = dt
            Registros.DataBind()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Try
            Session("detalle") = Nothing
            MostrarDatos()
            Server.Transfer("facturacion.aspx")
        Catch ex As Exception

        End Try
    End Sub
  
    Protected Sub Facturar_Click(sender As Object, e As EventArgs) Handles Facturar.Click
        Try
            'Server.Transfer("fCierre.aspx", False)
            Response.Redirect("fCierre.aspx")
        Catch ex As Exception
        End Try
    End Sub
    Protected Sub Lknbotonvalida_Click(sender As Object, e As EventArgs) Handles Lknbotonvalida.Click
        Server.Transfer("/app/existencia.aspx", True)
    End Sub
End Class


