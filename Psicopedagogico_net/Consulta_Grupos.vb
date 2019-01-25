Imports Datos
Public Class Consulta_Grupos

    Dim Metodos As New MetodosSQL
    Public dt As New DataTable
    Dim id_grupo As String


    Private Sub Consulta_Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Metodos.CargarSedes(dt)
            cb_plantel.DataSource = dt
            cb_plantel.ValueMember = "Sede"
            Grupos.Close()
            'Grid_ConsultaGrupos.Rows.Add("ETIQUETA", "QUITAR")
            'Metodos.ConsultaGrupos("", dt)
            'Grid_ConsultaGrupos.DataSource = dt
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Consulta_Grupos " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try

    End Sub

    Private Sub Grid_ConsultaGrupos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_ConsultaGrupos.CellContentClick
        Try
            id_grupo = Grid_ConsultaGrupos.Rows(e.RowIndex).Cells("ID_GRUPO").Value
            DsGrupos.Clear()
            Metodos.ConsultaGrupos(id_grupo, "", "", "", "", DsGrupos)

            Grupos.FormPadre = Me.Name
            Grupos.Show()
            Grupos.BringToFront()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "EXCEPCION DETECTADA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Dim form As New CRVisor
        Dim cr As New rpt_Grupos

        Try
            cr.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
            cr.SetDataSource(DsGrupos)
            form.CrystalReportViewer1.ReportSource = cr
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Try
            DsGrupos.Clear()
            Metodos.ConsultaGrupos("", cb_plantel.Text, txt_fecha1.Text, txt_fecha2.Text, txt_tema.Text, DsGrupos)

            Grid_ConsultaGrupos.DataSource = DsGrupos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)
       


    End Sub

    Private Sub txt_tema_TextChanged(sender As Object, e As EventArgs) Handles txt_tema.Click
        cb_plantel.Text = ""
        txt_fecha1.Text = ""
        txt_fecha2.Text = ""
        DateTimePicker_Inicio.Value = DateTime.Now
        DateTimePicker_Final.Value = DateTime.Now
    End Sub

    Private Sub cb_plantel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_plantel.Click
        txt_fecha1.Text = ""
        txt_fecha2.Text = ""
        txt_tema.Text = ""
    End Sub

    Private Sub DateTimePicker_Inicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_Inicio.ValueChanged
        cb_plantel.Text = ""
        txt_tema.Text = ""
        txt_fecha1.Text = DateTimePicker_Inicio.Value.ToShortDateString
        txt_fecha2.Text = DateTimePicker_Final.Value.ToShortDateString
    End Sub

    Private Sub DateTimePicker_Final_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_Final.ValueChanged
        cb_plantel.Text = ""
        txt_tema.Text = ""
        txt_fecha2.Text = DateTimePicker_Final.Value.ToShortDateString
        txt_fecha1.Text = DateTimePicker_Inicio.Value.ToShortDateString
    End Sub
End Class