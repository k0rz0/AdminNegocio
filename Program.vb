Imports System
Imports System.Windows.Forms

Module Program
    <STAThread>
    Sub Main()
        ' Configuración de la aplicación
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Iniciar con el formulario principal (FrmMenu)
        Application.Run(New Login())
    End Sub
End Module

