Imports Entidades
Public Class Form_Error
    Dim Entidades_Funciones As New Funciones
    Private Sub Form_Error_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        RichTextBox_Error.Text = Nothing
        Label_Error.Visible = True
    End Sub


    Private Sub Button_Guardar_Click(sender As Object, e As EventArgs) Handles Button_Guardar.Click
        If Entidades_Funciones.Envio_Correo_Error(RichTextBox_Error.Text & vbNewLine & RichTextBox_Mensaje.Text, Bienvenida.lbl_plantel_usuario.Text, Bienvenida.lbl_nombre_usuario.Text) = True Then
            MsgBox("Mensaje Enviado", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("El mensaje No se envio, verifique su coneccion a internet", MsgBoxStyle.Critical)
        End If
    End Sub
End Class