
Imports Npgsql
Module LoginBO
    ' Función para validar el usuario en la base de datos
    Public Function ValidarUsuario(usuario As String, contraseña As String) As String
        Dim query As String = "SELECT COUNT(*) FROM ""Usuarios"" WHERE ""Usuario"" = @usuario AND ""Contraseña"" = @contraseña"

        Try
            Using conn As NpgsqlConnection = GetConnection(),
              cmd As New NpgsqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@contraseña", contraseña)

                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                conn.Close()

                Return count > 0
            End Using

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    ' (Opcional) Función para obtener datos del usuario si es válido
    Public Function ObtenerDatosUsuario(usuario As String) As Dictionary(Of String, String)
        Dim query As String = "SELECT id, nombre, correo FROM Usuarios WHERE usuario = @usuario"
        Dim datos As New Dictionary(Of String, String)

        Using conn As NpgsqlConnection = GetConnection(),
              cmd As New NpgsqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@usuario", usuario)
            conn.Open()
            Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    datos("id") = reader("id").ToString()
                    datos("nombre") = reader("nombre").ToString()
                    datos("correo") = reader("correo").ToString()
                End If
            End Using
            conn.Close()
        End Using

        Return datos
    End Function
End Module
