Public Class Notificacion

    Private Sub Notificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LOGIN
        Acceso.ShowDialog()
       

    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Me.Close()
    End Sub

End Class
