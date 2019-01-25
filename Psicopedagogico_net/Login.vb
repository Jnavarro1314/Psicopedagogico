Imports Datos
Imports System.IO

Public Class Acceso
    Public nombre, sede, permiso As String
    Dim metodos As New MetodosSQL
    Dim Datos_Metodos As New MetodosSQL
    Dim pass, version, url As String

    Dim SesionIniciada As Boolean

    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            metodos.valida_version(version, url)
            If lbl_version.Text <> version Then
                'If MessageBox.Show("Hay una nueva actualizacion para este programa, ¿Desea actualizarlo ahora? Para actualizar de clic en el boton ACEPTAR, de lo  contrario NO podrá seguir utilizando el programa" &
                '                   vbCrLf & vbCrLf & "Nueva Version: " & version, "ACTUALIZACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                '    Process.Start(url)
                'End If
                Try
                    Dim N_Instalador As String
                    If Not Directory.Exists("C:\PSICOPEDAGOGICO\Actualizador") Then
                        Directory.CreateDirectory("C:\PSICOPEDAGOGICO\Actualizador")
                    End If

                    Descargando.Show()
                    Datos_Metodos.Descargar_Instalador("C:\PSICOPEDAGOGICO\Actualizador\", N_Instalador)
                    Descargando.Close()
                    Process.Start("C:\PSICOPEDAGOGICO\Actualizador\" & N_Instalador)
                    Me.Close()

                Catch ex As Exception
                    Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Instalar la actualizacion Automatica.  " & vbNewLine & ex.Message
                    Form_Error.ShowDialog()

                End Try
                Me.Close()
            Else
                If Not File.Exists("C:\PSICOPEDAGOGICO\Version.txt") Then
                    Versionver()
                Else
                    Dim fulltext As String = File.ReadAllText("C:\PSICOPEDAGOGICO\Version.txt")
                    Dim partes() As String = fulltext.Split(Environment.NewLine)
                    Dim ultimalinea As String = partes(partes.Length - 1)
                    If ultimalinea <> lbl_version.Text Then
                        Versionver()
                    End If

                End If

            End If


        Catch ex As Exception
            ' MsgBox("El Servidor Remoto No Responde, Por Favor Intentelo mas Tarde. " & ex.Message, MsgBoxStyle.Critical)
            Dim readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\TeamViewer", "ClientID", Nothing)
            Form_Error.RichTextBox_Error.Text = "El Servidor Remoto No Responde, Por Favor Intentelo mas Tarde. " & My.Computer.Name & " - " & readValue & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()
        End Try
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        logeo()
    End Sub

    Private Sub NotifyIcon_Actualizaciones_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon_Actualizaciones.MouseDoubleClick

    End Sub

    Private Sub txt_contraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contraseña.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                logeo()
        End Select
    End Sub

    Public Sub logeo()
        Try
            ' metodos.valida_usuario(txt_usuario.Text, txt_contraseña.Text, user, pass, Me.Name, cuenta, estatus)

            
                If txt_usuario.Text = "" Then
                    MessageBox.Show("Escribe tu usuario", "Validación de cuentas de usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txt_usuario.Focus()

                ElseIf txt_contraseña.Text = "" Then
                    MessageBox.Show("Escribe tu contraseña", "Validación de cuentas de usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txt_contraseña.Focus()

                Else
                    metodos.ConsultarPermisos(txt_usuario.Text, permiso, "")
                    metodos.ConsultarBDSaii(txt_usuario.Text, nombre, "", sede, "", "", "Login", pass)

                    If txt_contraseña.Text.ToUpper = pass Or txt_contraseña.Text.ToLower = pass Then
                    SesionIniciada = True
                    Me.Close()

                Else
                        MessageBox.Show("El usuario o contraseña son incorrectos, inténtalo Nuevamente", "Validación de cuentas de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txt_contraseña.Text = ""

                    End If

                End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Acceso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SesionIniciada = False Then
            Notificacion.Close()
            Bienvenida.Close()
        End If
    End Sub
    Sub Versionver()
        If Not Directory.Exists("C:\PSICOPEDAGOGICO") Then
            Directory.CreateDirectory("C:\PSICOPEDAGOGICO")
            ' My.Computer.FileSystem.CopyFile(Rutad, "C:\ASiS\" + CStr(OPFile.SafeFileName), True)
            Dim ruta As String = "C:\PSICOPEDAGOGICO\Version.txt"
            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(lbl_version.Text)
            escritor.Flush()
            escritor.Close()
        Else
            ' Index.BackgroundImage = Nothing
            '' My.Computer.FileSystem.DeleteDirectory("C:\Uni\", FileIO.DeleteDirectoryOption.DeleteAllContents, FileIO.RecycleOption.DeletePermanently)
            ''My.Computer.FileSystem.CopyFile(Rutad, "C:\Uni\" + CStr(OPFile.SafeFileName), False)
            Using file As New IO.StreamWriter("C:\PSICOPEDAGOGICO\Version.txt")
                file.Flush()
            End Using
            'My.Computer.FileSystem.CopyFile(Rutad, "C:\ASiS\" + CStr(OPFile.SafeFileName), True)
            Dim ruta As String = "C:\PSICOPEDAGOGICO\Version.txt"
            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(lbl_version.Text)
            escritor.Flush()
            escritor.Close()



        End If

        Dim fulltext As String = File.ReadAllText("C:\PSICOPEDAGOGICO\Version.txt")

        Dim partes() As String = fulltext.Split(Environment.NewLine)

        Dim ultimalinea As String = RTrim(partes(partes.Length - 1))
        NotifyIcon_Actualizaciones.Visible = True
        'NotifyIcon_Actualizaciones.ShowBalloonTip(100)
        Me.NotifyIcon_Actualizaciones.ShowBalloonTip(10000, "Nueva version " & ultimalinea, "Se Instalaron Actualizaciones Automaticas", ToolTipIcon.Info)
    End Sub
End Class
