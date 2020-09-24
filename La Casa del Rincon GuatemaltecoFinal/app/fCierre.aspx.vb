Public Class fCierre
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtfecha.Text = DateTime.Now.ToString("yyyy/MM/dd")

            If (Not IsPostBack) Then
                MostrarDatos()
                CargarCliente()
                CargarPago()
                cargarNit(DropListcliente)

            End If
        Catch ex As Exception
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
    Private Sub CargarCliente()
        Try
            Dim db As New MysqlDB
            Dim sSql As String
            Dim dt As New DataTable

            sSql = "Select id_cliente,nombre_cliente from Cliente"
            dt = db.ejecutarConsulta(sSql)
            For Each Row As DataRow In dt.Rows
                DropListcliente.Items.Add(
                    New ListItem(Row("nombre_cliente").ToString(),
                                 Row("id_cliente").ToString()
                                 ))
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CargarPago()
        Try
            DropListpago.Items.Add(
             New ListItem("Efectivo"))
            DropListpago.Items.Add(
            New ListItem("Visa"))

        Catch ex As Exception

        End Try

    End Sub
    Protected Sub lnkimprimir_Click(sender As Object, e As EventArgs) Handles lnkImprimir.Click
        Try
            Dim dt As DataTable = Session("detalle")
            Dim nr As DataRow = dt.NewRow
            Dim db As New MysqlDB
            Dim total As New Double
            Dim dtm As New DataTable
            Dim idpedido As String
            total = 0
            'Dim dt As DataTable = Session("detalle")
            For Each row As DataRow In dt.Rows
                total = total + Double.Parse(row("Subtotal"))
            Next
            Dim Sql As String = "Insert into Pedido(cliente_id_cliente, fecha, total) values(" + DropListcliente.SelectedValue + ",'" + txtfecha.Text.ToString() + "'," + total.ToString + ");"
            db.ejecutarConsulta(Sql)
            dtm = db.ejecutarConsulta("select @@identity as id;")
            idpedido = dtm(0).Item("id").ToString()
            Session("id_ultimopedido") = idpedido
            For Each row As DataRow In dt.Rows
                db.ejecutarConsulta("Insert into DetallePedido(id_Pedido,Cantidad,subtotal,id_productodetalle) values(" + idpedido + "," + row("cantidad").ToString() + "," + row("Subtotal").ToString() + "," + row("idproducto").ToString() + ")")
                db.ejecutarConsulta("update producto set Existencia = Existencia -" + row("cantidad").ToString() + " where id_producto =" + row("idproducto").ToString())
            Next
            'ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('" + Sql + "')", True)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Facturacion Completa')", True)
            Session("detalle") = Nothing
            MostrarDatos()
            Response.Redirect("emitefactura.aspx")
        Catch ex As Exception
            Throw ex
            ' Si lanza una excepcion no proceso la consulta
        End Try
    End Sub

    Protected Sub DropListcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropListcliente.SelectedIndexChanged
        Try
            cargarNit(sender)
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Sub cargarNit(obj As Object)
        Try
            Dim cmb As DropDownList = CType(obj, DropDownList)

            Dim idCliente As String = cmb.SelectedValue
            'ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('" + idCliente + "')", True)
            Dim db As New MysqlDB
            Dim sSql As String
            Dim dt As New DataTable

            sSql = "select nit from cliente where id_cliente = " + idCliente
            dt = db.ejecutarConsulta(sSql)

            txtnit.Text = dt(0).Item("nit").ToString()


        Catch ex As Exception

        End Try
    End Sub

End Class