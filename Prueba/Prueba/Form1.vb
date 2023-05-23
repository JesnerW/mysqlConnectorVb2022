Imports MySql.Data.MySqlClient
Imports Prueba.ConexionDB
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As MySqlConnection = ConexionDB.ObtenerConexion()
            Try
                connection.Open()

                If connection.State = ConnectionState.Open Then
                    LabelEstado.Text = "Conectado"
                Else
                    LabelEstado.Text = "No conectado"
                End If

                connection.Close()
            Catch ex As Exception
                LabelEstado.Text = "Error al conectar: " & ex.ToString()
            End Try
        End Using
    End Sub
End Class
