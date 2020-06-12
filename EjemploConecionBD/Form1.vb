Imports System.Data.Odbc

Public Class Form1

    Private StringDeConexion As String = "DRIVER=MySQL ODBC 8.0 UNICODE Driver;UID=root;PWD=linux66!;PORT=3306;DATABASE=prueba;SERVER=localhost"

    Private Lector As OdbcDataReader

    Private Sub CargaDatos()
        Dim conexion As New OdbcConnection(StringDeConexion)
        conexion.Open()

        Dim comando As New OdbcCommand

        comando.CommandText = "SELECT * FROM persona"
        comando.Connection = conexion

        Me.Lector = comando.ExecuteReader()

    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Dim conexion As New OdbcConnection(StringDeConexion)
        conexion.Open()

        Dim comando As New OdbcCommand
        comando.CommandText = "INSERT INTO persona VALUES(" + txtID.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtEmail.Text + "')"
        comando.Connection = conexion

        MsgBox("Conectada")

        comando.ExecuteNonQuery()

        MsgBox("Presona ingresada correctamente")

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim conexion As New OdbcConnection(StringDeConexion)
        conexion.Open()

        Dim comando As New OdbcCommand
        comando.CommandText = "UPDATE persona SET nombre ='" + txtNombre.Text + "',apellido ='" + txtApellido.Text + "',mail ='" + txtEmail.Text + "' WHERE id =" + txtID.Text + ""
        comando.Connection = conexion

        comando.ExecuteNonQuery()

        MsgBox("Presona Modificada correctamente")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim conexion As New OdbcConnection(StringDeConexion)
        conexion.Open()

        Dim comando As New OdbcCommand
        comando.CommandText = "DELETE FROM persona WHERE id =" + txtID.Text + ""
        comando.Connection = conexion

        comando.ExecuteNonQuery()

        MsgBox("Presona Eliminada correctamente")

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargaDatos()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        Lector.Read()
        txtID.Text = Lector(0).ToString()
        txtNombre.Text = Lector(1).ToString()
        txtApellido.Text = Lector(2).ToString()
        txtEmail.Text = Lector(3).ToString()

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click

        Dim tabla As New DataTable
        CargaDatos()
        tabla.Load(Me.Lector)
        GrillaDatos.DataSource = tabla

    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click

        Dim conexion As New OdbcConnection(StringDeConexion)
        conexion.Open()

        Dim comando As New OdbcCommand
        comando.CommandText = "SELECT COUNT(*) From persona"
        comando.Connection = conexion

        comando.ExecuteNonQuery()

        MsgBox("Cantidad de Registros => " + comando.ExecuteScalar().ToString())

    End Sub
End Class
