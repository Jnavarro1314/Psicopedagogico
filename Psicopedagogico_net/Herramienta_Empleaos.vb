Imports Datos

Public Class Herramienta_Empleaos
    Dim datos_Metodos As New MetodosSQL
    Private Sub Herramienta_Empleaos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datos_Metodos.Descargar_Fotos()
    End Sub
End Class