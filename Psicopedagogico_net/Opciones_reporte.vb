Imports Datos
Imports System.Threading
Public Class Opciones_reporte
    Dim metodos As New MetodosSQL

    Private Sub Btn_Reporte_Click(sender As Object, e As EventArgs) Handles Btn_Reporte.Click

        Dim formato As New rpt_formato
        Dim visor As New CRVisor
        Try
            If txt_no_vacios(Me) = True Then
                MessageBox.Show("Hay campos vacíos. Asegúrate de ingresar todos los datos", "Validación de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf metodos.valida_folio(txt_folio.Text) = "" Then
                MessageBox.Show("El folio ingresado no existe, favor de verificar", "Validación de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                formato.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")           '-- para que no me pida la contraseña del servidor
                formato.SetParameterValue("solicito", txt_solicita.Text)
                formato.SetParameterValue("recibio", txt_recibe.Text)
                formato.SetParameterValue("puesto_sol", txt_soli_puesto.Text)
                formato.SetParameterValue("puesto_rec", txt_recib_puesto.Text)
                formato.SetParameterValue("@folio_alumno", txt_folio.Text)
                visor.CrystalReportViewer1.ReportSource = formato
                visor.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function txt_no_vacios(ByVal Grupo As Windows.Forms.Form)
        Dim miControl As Object
        Dim vacios As Boolean = False
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                If miControl.text = "" Then
                    vacios = True
                    Exit For
                End If
            End If
        Next
        Return vacios
    End Function

    Private Sub Opciones_reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpiar_campos(Me)
        ' BackgroundWorker1.RunWorkerAsync()
    End Sub

    Public Function limpiar_campos(ByVal Grupo As Windows.Forms.Form)
        Dim miControl As Object
        Dim vacios As Boolean = False
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Or miControl.GetType Is GetType(System.Windows.Forms.ComboBox) Then
                miControl.text = ""
            End If
        Next
        Return vacios
    End Function

End Class