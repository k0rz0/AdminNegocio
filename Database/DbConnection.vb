
Imports Npgsql
Module DbConnection
    ' Usa la URL de Railway (reemplaza los valores)
    Private ReadOnly connectionString As String = "Host=switchyard.proxy.rlwy.net;Port=44133;Database=postgres;Username=postgres;Password=jbhmDSJDaRLUYDPSwgOfJEqoIdCghQjS;"

    ' Función para obtener la conexión
    Public Function GetConnection() As NpgsqlConnection
        Return New NpgsqlConnection(connectionString)
    End Function
End Module
