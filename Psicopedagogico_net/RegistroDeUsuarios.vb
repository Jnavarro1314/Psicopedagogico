Imports Datos
Public Class RegistroDeUsuarios

    Dim metodos As New MetodosSQL
    Dim dtTable As New DataTable

    Private Sub RegistroDeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            metodos.CargarSedes(dtTable)
            CB_Plantel.DataSource = dtTable
            CB_Plantel.DisplayMember = "Sede"
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Registro de usuarios " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            If txt_no_vacios(GB_1) = True Or txt_no_vacios(GB_2) = True Or txt_no_vacios(GB_3) = True Then
                MessageBox.Show("Hay campos vacíos, porfavor ingrese la información completa", "Validación de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf txt_usuario.Text = metodos.valida_usuarios_duplicados(txt_usuario.Text) Then
                MessageBox.Show("Este nombre de usuario no esta disponible, elije otro usuario e intenta nuevamente", "Validación de Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_usuario.Focus()

            ElseIf txt_clave.Text = txt_confirmar_clave.Text Then
                metodos.RegistrarUsuario(txt_nombre.Text, txt_apellidos.Text, CB_Plantel.SelectedItem, CB_Depto.Text, txt_puesto.Text, CB_cuenta.SelectedItem, txt_usuario.Text, txt_clave.Text)
                MessageBox.Show("Usuario Registrado Correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Limpiar_GB(GB_1)
                Limpiar_GB(GB_2)
                Limpiar_GB(GB_3)
            Else
                MessageBox.Show("Las contraseñas no coinciden, inténtalo Nuevamente", "Validación de Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_clave.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Limpiar_GB(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                miControl.Clear()
            End If
        Next
    End Sub

    Public Function txt_no_vacios(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        Dim vacios As Boolean = False
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Or miControl.GetType Is GetType(System.Windows.Forms.ComboBox) Then
                If miControl.text = "" Then
                    vacios = True
                    Exit For
                End If
            End If
        Next
        Return vacios
    End Function

    Private Sub chk_mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mostrar.CheckedChanged
        If chk_mostrar.Checked = True Then
            txt_clave.UseSystemPasswordChar = False
            txt_confirmar_clave.UseSystemPasswordChar = False
        Else
            txt_clave.UseSystemPasswordChar = True
            txt_confirmar_clave.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Limpiar_GB(GB_1)
        Limpiar_GB(GB_2)
        Limpiar_GB(GB_3)
    End Sub

    Private Sub CB_Depto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Depto.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

End Class