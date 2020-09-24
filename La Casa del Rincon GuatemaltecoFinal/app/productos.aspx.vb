Public Class productos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If (Not IsPostBack) Then
                MostrarDatos()
                CargarProveedor()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub lnkGuardar_Click(sender As Object, e As EventArgs) Handles lnkGuardar.Click
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            sSql = "insert into Producto(nom_producto, departamento, precio_venta, Existencia,Proveedor_idproveedor) values('" +
                txtNombre.Text.ToString() + "','" +
                txtDepartamento.Text.ToString() + "','" +
                txtPrecio.Text.ToString() + "','" +
                txtExistencia.Text.ToString() + "'," +
                DropDownList1.SelectedValue.ToString + ")"
            'ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('script: " + sSql + "')", True)
            db.ejecutarConsulta(sSql)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Producto Ingresado con Exito...')", True)
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

            sSql = "Select id_producto,nom_producto,departamento,precio_venta,Existencia,nom_proveedor from producto,proveedor where producto.Proveedor_idproveedor=proveedor.idproveedor order by id_producto Desc limit 10"
            Registros.DataSource = db.ejecutarConsulta(sSql)
            Registros.DataBind()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargarProveedor()
        Try
            Dim db As New MysqlDB
            Dim sSql As String
            Dim dt As New DataTable

            sSql = "Select idproveedor,nom_proveedor from Proveedor "
            dt = db.ejecutarConsulta(sSql)
            For Each Row As DataRow In dt.Rows
                DropDownList1.Items.Add(
                    New ListItem(Row("nom_proveedor").ToString(),
                                 Row("idproveedor").ToString()
                                 ))
            Next
        Catch ex As Exception

        End Try

    End Sub
   
    
    
   
    Protected Sub Registros_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles Registros.RowDeleting
        Try
            Dim db As New MysqlDB
            Dim sSql As String

            Dim id As String = e.RowIndex
            Dim idProducto As String = Registros.Rows(id).Cells(0).Text.ToString()
            sSql = "Delete from producto where id_producto=" + idProducto
            db.ejecutarConsulta(sSql)
            MostrarDatos()
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "mensaje", "alert('Producto eliminado correctamente')", True)

        Catch ex As Exception

        End Try
    End Sub
    Protected Sub Linknuevo_Click(sender As Object, e As EventArgs) Handles Linknuevo.Click
        txtNombre.Text = " "
        txtDepartamento.Text = " "
        txtExistencia.Text = " "
        txtPrecio.Text = ""
    End Sub
End Class