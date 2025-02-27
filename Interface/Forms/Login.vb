Imports Npgsql

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        Dim usuario As String = txtUsuario.Text
        Dim contraseña As String = txtContraseña.Text

        Try
            If usuario.Equals("") And contraseña.Equals("") Then
                MessageBox.Show("No se pudo iniciar Sessión. Debe ingresar usuario y contraseña", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim respuesta As String = ValidarUsuario(usuario, contraseña)

            If respuesta.Equals("True") Then
                MessageBox.Show("Bienvenido, " & usuario, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
