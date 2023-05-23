Imports MySql.Data.MySqlClient

Public Class ConexionDB
    Public Shared Function ObtenerConexion() As MySqlConnection
        Dim connectionString As String = "Server=localhost;Database=prueba;Uid=root;Pwd=1234;SslMode=Required"
        Dim connection As New MySqlConnection(connectionString)
        Return connection
    End Function
End Class

