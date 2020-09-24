Imports MySql.Data.MySqlClient
Imports System.Data



Public Class MysqlDB

    Private conexion As MySqlConnection
    Private cadena_conexion As String = "server = localhost;database=dbrepuestos;user id= root;contraseña=;SslMode = none"

    Public Sub New()

        Me.conexion = New MySqlConnection(Me.cadena_conexion)
        Me.conexion.Open()
         
    End Sub

    Public Function ejecutarConsulta(ByVal query As String)

        Dim tabla As New DataTable
        Dim adaptador As New MySqlDataAdapter
        Dim cmd As New MySqlCommand


        cmd.Connection = Me.conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query
        adaptador.SelectCommand = cmd
        adaptador.Fill(tabla)
        If (Me.conexion.State = ConnectionState.Open) Then
            Me.conexion.Close()
        End If

        Return tabla


    End Function




End Class

