Imports Datos
Imports System.IO

Public Class Bienvenida

    Dim metodos As New MetodosSQL
    Dim ms = New MemoryStream()
    Dim ArchivoAbierto As Boolean
    Dim Rutad As String
    Dim Datos_Metodos As New MetodosSQL
    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Notificacion.ShowDialog()

        'MI LOAD
        'metodos.valida_usuario(Acceso.txt_usuario.Text, Acceso.txt_contraseña.Text, lbl_nombre_usuario.Text, lbl_plantel_usuario.Text, Me.Name, lbl_cuenta.Text, "")

        lbl_cuenta.Text = Acceso.permiso
        lbl_nombre_usuario.Text = Acceso.nombre
        lbl_plantel_usuario.Text = Acceso.sede

        If lbl_cuenta.Text = "RECTORIA" Or lbl_cuenta.Text = "DIRECCION DES. INTEGRAL" Then

            MenuStrip1.Items.Remove(Menu_actualizar)
            MenuStrip1.Items.Remove(Menu_capturar)
            '--MenuStrip1.Location = New Point(304, 481)
            MenuStrip1.Location = New Point(153, 481)

        ElseIf lbl_cuenta.Text = "ADMINISTRADOR" Then
            link_registro.Visible = True
        End If
        'Cargando.Show()
        Inventariar()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Inventariar()
        If Not File.Exists("C:\PSICOPEDAGOGICO\Inventario_CPU " & DateTime.Now.ToString("yyyy") & ".txt") Then
            BackgroundWorker_Inventariar.RunWorkerAsync()
            Cargando.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Menu_capturar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_consultar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_imprimir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_actualizar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_grupos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TamizajeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_sintesis_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_graficar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSubir_Click(sender As Object, e As EventArgs) Handles BtnSubir.Click
        Try
            Dim mipdf As FileStream
            Dim arrImage() As Byte
            Dim info As String = ""
            OpenFileDialog1.Filter = "PDF|*.pdf|Todos los Archivos|*.*"
            OpenFileDialog1.Title = "Seleccione un archivo"


            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                info = OpenFileDialog1.FileName

                mipdf = File.OpenRead(info)
                ReDim arrImage(mipdf.Length)
                mipdf.Read(arrImage, 0, mipdf.Length)
                'arrImage = ms.GetBuffer
                metodos.GuardarManual(arrImage)
            End If
            MsgBox("Archivo Guardado Correctamente ;)", MsgBoxStyle.OkCancel, "Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LinkDescarga_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDescarga.LinkClicked
        Try
            Dim manual As Object = ""
            metodos.DescargarManual(manual)

            Dim imagen As Byte() = Nothing
            imagen = manual

            'If ArchivoAbierto = False Then

            Dim fs As System.IO.FileStream = New System.IO.FileStream("ManualPDF", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
            Dim bw As New System.IO.BinaryWriter(fs)
            bw.Write(imagen)
            bw.Flush()
            bw.Close()
            fs.Close()

            'Abrir el archivo 
            Dim Command As New Process
            Command.StartInfo.FileName = "ManualPDF"
            Command.StartInfo.UseShellExecute = True
            Command.StartInfo.CreateNoWindow = True
            Command.Start()

            ArchivoAbierto = True
            'Else
            'MessageBox.Show("El archivo ya está abierto, buscalo en tu navegador", "Validando procesos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim File As New OpenFileDialog
        File.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        File.Title = "Seleccione El Instalador"
        File.RestoreDirectory = True
        'File.Filter = "|*.ldf"

        If File.ShowDialog = Windows.Forms.DialogResult.OK Then
            Rutad = File.FileName
            Cargando.Show()
            BackgroundWorker_Cargar_Actualizador.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker_Cargar_Actualizador_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Cargar_Actualizador.DoWork
        Datos_Metodos.Cargar_Instalador_ASiS(Rutad)
    End Sub

    Private Sub BackgroundWorker_Cargar_Actualizador_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker_Cargar_Actualizador.RunWorkerCompleted
        Cargando.Close()
    End Sub
    Private Sub GenerarInventario()
        Dim ruta As String = "C:\PSICOPEDAGOGICO\Inventario_CPU " & DateTime.Now.ToString("yyyy") & ".txt"
        Dim escritor As StreamWriter
        escritor = File.AppendText(ruta)
        escritor.Write("Inventariada " & DateTime.Now.ToString)
        escritor.Flush()
        escritor.Close()
        Datos_Metodos.Nuevo_Inventario(Inventario.Label_Serie.Text, Inventario.Label_Nombre.Text, Inventario.Label_Tarjeta_Madre.Text, Inventario.RichTextBox_DiscosDuros.Text, Inventario.Label_Ram.Text, Inventario.Label_Procesador.Text,
                                       Inventario.Label_SO.Text, Inventario.Label_IPLocal.Text, Inventario.Label_IPPublica.Text, DateTime.Now.ToShortDateString, lbl_plantel_usuario.Text, lbl_nombre_usuario.Text)
    End Sub

    Private Sub BackgroundWorker_Inventariar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Inventariar.DoWork
        Inventario.Label_Usuario.Text = lbl_nombre_usuario.Text
        Inventario.Inventario_Load(Nothing, Nothing)
        GenerarInventario()
    End Sub

    Private Sub BackgroundWorker_Inventariar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker_Inventariar.RunWorkerCompleted
        Cargando.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inventario.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevosIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_capturar.Click
        Try
            Captura.Show()
            Captura.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ReportesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Menu_consultar.Click
        Try
            If lbl_cuenta.Text = "INVITADO" Then
                Consultas_invitado.Show()
                Consultas_invitado.BringToFront()
            Else
                Consultas.Show()
                Consultas.BringToFront()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LeadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_imprimir.Click
        Try
            Opciones_reporte.Show()
            Opciones_reporte.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_actualizar.Click
        Try
            Actualizar.Show()
            Actualizar.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AtenciónAGruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_grupos.Click
        Try
            Grupos.FormPadre = Me.Name
            Grupos.Show()
            Grupos.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ResultadosDeTamizajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamizajeToolStripMenuItem.Click
        Try
            Tamizaje.Show()
            Tamizaje.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SíntesisSemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_sintesis.Click
        Try
            Sintesis.Show()
            Sintesis.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GraficarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_graficar.Click
        Try
            Graficos.Show()
            Graficos.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub REGISTRODEASISTENCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Registro_Asistencia.Show()
    End Sub

    Private Sub ToolStripSplitButton_ControlUsuarios_Click(sender As Object, e As EventArgs) Handles link_registro.Click
        Try
            Usuarios.Show()
            Usuarios.BringToFront()
            'RegistroDeUsuarios.Show()
            'RegistroDeUsuarios.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PlataformaWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlataformaWebToolStripMenuItem.Click
        Process.Start("https://www.google.com.mx/")
    End Sub


End Class