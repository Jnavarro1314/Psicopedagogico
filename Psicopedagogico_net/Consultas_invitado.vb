Imports Datos
Public Class Consultas_invitado
    Dim metodos As New MetodosSQL
    Dim dtTable As New DataTable    'grid
    Dim dt As New DataTable         'combo
    Dim combo As Boolean = False
    Dim valor, campo As String

    Private Sub Consultas_invitado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            grid_estadistica.DataSource = ""
            Grid_folio.DataSource = ""
            txt_folio.Text = ""

            metodos.ciudad_invitado(Bienvenida.lbl_plantel_usuario.Text.Substring(0, 6), dt)

            cb_plantel.DataSource = dt
            cb_plantel2.DataSource = dt
            cb_plantel.DisplayMember = dt.Columns("plantel").ToString
            cb_plantel2.DisplayMember = dt.Columns("plantel").ToString

        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Consultas_invitado " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub

    Public Sub grafico()
        Chart1.Series("DISCAPACIDAD").Points.AddXY("Disc-Adic-Enf", txt_total_disc.Text)
        Chart1.Series("ADICCION").Points.AddXY("", txt_total_adic.Text)
        Chart1.Series("ENFERMEDAD").Points.AddXY("", txt_total_enf.Text)
    End Sub

    Public Sub grafico_pie()
        Chart_pie.Series("Serie1").Points.AddXY("Discap. " & txt_total_disc.Text, txt_total_disc.Text)
        Chart_pie.Series("Serie1").Points.AddXY("Adic. " & txt_total_adic.Text, txt_total_adic.Text)
        Chart_pie.Series("Serie1").Points.AddXY("Enferm. " & txt_total_enf.Text, txt_total_enf.Text)

        Chart_pie.Series("Serie1").Points(0).LegendText = "DISCAPACIDAD"
        Chart_pie.Series("Serie1").Points(1).LegendText = "ADICCION"
        Chart_pie.Series("Serie1").Points(2).LegendText = "ENFERMEDAD"
    End Sub


    Private Sub Link_discapacidad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_discapacidad.LinkClicked
        metodos.proc_Estadisticas("DISCAPACIDAD", cb_plantel.Text, dtTable)
        grid_estadistica.DataSource = dtTable
    End Sub

    Private Sub Link_Adiccion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_Adiccion.LinkClicked
        metodos.proc_Estadisticas("ADICCION", cb_plantel.Text, dtTable)
        grid_estadistica.DataSource = dtTable
    End Sub

    Private Sub Link_Enfermedad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_Enfermedad.LinkClicked
        metodos.proc_Estadisticas("ENFERMEDAD", cb_plantel.Text, dtTable)
        grid_estadistica.DataSource = dtTable
    End Sub

    Private Sub cb_plantel_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_plantel.SelectionChangeCommitted
        Try
            If Chart_pie.Series.Count > 0 Then
                Chart_pie.Series("Serie1").Points.Clear()
            End If
            metodos.estadisticas(cb_plantel.Text, txt_total_disc.Text, txt_total_adic.Text, txt_total_enf.Text, DateTimePicker_Inicio.Value.ToShortDateString, DateTimePicker_Final.Value.ToShortDateString)
            txt_total.Text = metodos.total(cb_plantel.Text)
            grafico_pie()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '----------------------------------TABPAGE2------------------------------------------------------------------------


    Private Sub cb_plantel2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_plantel2.SelectionChangeCommitted
        Try
            txt_folio.Text = ""
            DsAlumno.Clear()
            metodos.proc_verPorPlantel("plantel", cb_plantel2.Text, DsAlumno)
            Grid_folio.DataSource = DsAlumno.Tables(0)
            Lbl_registros.Text = "Total " & Grid_folio.Rows.Count() & " Registros"
            combo = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Try
            DsAlumno.Clear()

            If Chk_vertodo.Checked = True Then
                campo = "ciudad"
                valor = cb_plantel2.Text.Substring(0, 6)
            Else
                campo = txt_folio.Text
                valor = cb_plantel2.Text
            End If
            metodos.proc_verPorPlantel(campo, valor, DsAlumno)
            Grid_folio.DataSource = DsAlumno.Tables(0)
            Lbl_registros.Text = "Total " & Grid_folio.Rows.Count() & " Registros"
            combo = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Chk_vertodo_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_vertodo.CheckedChanged
        If Chk_vertodo.Checked = True Then
            txt_folio.Text = ""
            txt_folio.Enabled = False
            cb_plantel2.Enabled = False
        Else
            txt_folio.Enabled = True
            cb_plantel2.Enabled = True
        End If
    End Sub

    Private Sub Btn_imprimir_Click(sender As Object, e As EventArgs) Handles Btn_imprimir.Click
        Try
            ' Dim rpt_info As New rpt_info_por_plantel
            Dim rpt_info As New rpt_InfoAlumno
            Dim form As New CRVisor

            rpt_info.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
            rpt_info.SetDataSource(DsAlumno)
            form.CrystalReportViewer1.ReportSource = rpt_info
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btn_Graficar_Click(sender As Object, e As EventArgs) Handles Btn_Graficar.Click
        Graficos.cuenta = Me.Name
        Graficos.Show()
        Graficos.BringToFront()
    End Sub

    Private Sub Btn_sintesis_Click(sender As Object, e As EventArgs) Handles Btn_sintesis.Click
        Sintesis.padre = Me.Name
        Sintesis.Show()
        Sintesis.BringToFront()
    End Sub
End Class