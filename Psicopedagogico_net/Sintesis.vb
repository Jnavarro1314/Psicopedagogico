Imports Datos
Public Class Sintesis
    Dim metodos As New MetodosSQL
    Dim dt As New DataTable
    Public padre As String

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        txt_fecha1.Text = MonthCalendar1.SelectionStart
        txt_fecha2.Text = DateAdd(DateInterval.Day, 7, MonthCalendar1.SelectionStart)
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            If txt_fecha1.Text = "" Then
                MessageBox.Show("Selecciona una fecha del calendario", "Validando Datos de ingreso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Else
                If padre = "Consultas_invitado" Then
                    metodos.PROC_SINTESIS2(txt_fecha1.Text, txt_fecha2.Text, dt, Consultas_invitado.cb_plantel2.Text.Substring(0, 6))
                Else
                    metodos.PROC_SINTESIS2(txt_fecha1.Text, txt_fecha2.Text, dt, "")
                End If
                ' metodos.proc_sintesis(txt_fecha1.Text, txt_fecha2.Text, dt)
                lbl_total.Text = dt.Rows.Count & " REGISTROS"
                lbl_periodo.Text = " DEL " & txt_fecha1.Text & " AL " & txt_fecha2.Text
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No se realizaron registros en el periodo seleccionado", "No hay datos para mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    grid_sintesis.DataSource = dt
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub imprimir()
        Try
            Dim rpt As New rpt_sintesis   '--rpt_sintesis_Copia
            Dim visor As New CRVisor
            rpt.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
            rpt.SetParameterValue("@fecha_inicio", txt_fecha1.Text)
            rpt.SetParameterValue("@fecha_final", txt_fecha2.Text)
            If padre = "Consultas_invitado" Then
                rpt.SetParameterValue("@ciudad", Consultas_invitado.cb_plantel2.Text.Substring(0, 6))
            Else
                rpt.SetParameterValue("@ciudad", "")
            End If

            visor.CrystalReportViewer1.ReportSource = rpt
            visor.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If txt_fecha1.Text = "" Then
            MessageBox.Show("Selecciona una fecha del calendario", "Validando Datos de ingreso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else
            imprimir()
        End If
    End Sub

    Private Sub Sintesis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dt.Clear()
    End Sub

    Private Sub Sintesis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class