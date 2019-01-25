Imports Datos
Imports Entidades
Public Class Consultas

    Dim metodos As New MetodosSQL
    Dim dtTable As New DataTable
    Dim tipo_cuenta As String
    Dim combo As Boolean = False
    Dim valor, campo As String
    Dim Rutina As New funciones

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tipo_cuenta = Bienvenida.lbl_cuenta.Text

            If tipo_cuenta = "RECTORIA" Or tipo_cuenta = "DIRECCION DES. INTEGRAL" Then
                TabControl_menu.TabPages.RemoveByKey("TabPage2")
                TabControl_menu.TabPages.RemoveByKey("TabPage4")
            Else
                TabControl_menu.TabPages.RemoveByKey("TabPage3")
            End If

       
        'PlantelesTableAdapter.Fill(Me.SedesDataSet.Planteles)
        metodos.CargarSedes(dtTable)
        ListBox1.DataSource = dtTable
        ListBox1.ValueMember = "Sede"

        cb_plantel.DataSource = dtTable
        cb_plantel.DisplayMember = "Sede"

            txt_total.Text = metodos.total(Bienvenida.lbl_plantel_usuario.Text)
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Consultas " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.Click
        'Chart_grafico.Series("DISCAPACIDAD").Points.Clear()
        'Chart_grafico.Series("ADICCION").Points.Clear()
        'Chart_grafico.Series("ENFERMEDAD").Points.Clear()

        Chart_pie.Series("Serie1").Points.Clear()
        Try
            metodos.estadisticas(ListBox1.Text, txt_total_disc.Text, txt_total_adic.Text, txt_total_enf.Text, DateTimePicker_Inicio.Value.ToShortDateString, DateTimePicker_Final.Value.ToShortDateString)
            Txt_total_porPlantel.Text = metodos.total(ListBox1.Text)
            '  grafico()
            grafico_pie()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Try
            'metodos.proc_verTodo(txt_folio.Text, dtTable)
            DsAlumno.Clear()

            If TxtNombre.Text = "" And TxtNombre.Enabled = True Then
                valor = txt_folio.Text
                campo = "folio"
            ElseIf txt_folio.Text = "" And txt_folio.Enabled=True Then
                valor = TxtNombre.Text
                campo = "nombre"
            Else
                valor = ""
                campo = "todo"
            End If

            metodos.proc_verPorPlantel(campo, valor, DsAlumno)

            Grid_folio.DataSource = DTInformacionBindingSource
            Lbl_registros.Text = "Total " & Grid_folio.Rows.Count() & " Registros"
            combo = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub grafico()
        Chart_grafico.Series("DISCAPACIDAD").Points.AddXY("Disc-Adic-Enf", txt_total_disc.Text)
        Chart_grafico.Series("ADICCION").Points.AddXY("", txt_total_adic.Text)
        Chart_grafico.Series("ENFERMEDAD").Points.AddXY("", txt_total_enf.Text)
        lbl_plantel.Text = ListBox1.Text
        'Chart1.Series("Series1").Points.AddY("Disc", txt_total_disc.Text)
        'Chart1.Series("Series1").Points.AddY("Adic", txt_total_adic.Text)
        'Chart1.Series("Series1").Points.AddY("Enf", txt_total_enf.Text)
    End Sub

    Public Sub grafico_pie()
        Chart_pie.Series("Serie1").Points.AddXY("Discap. " & txt_total_disc.Text, txt_total_disc.Text)
        Chart_pie.Series("Serie1").Points.AddXY("Adic. " & txt_total_adic.Text, txt_total_adic.Text)
        Chart_pie.Series("Serie1").Points.AddXY("Enferm. " & txt_total_enf.Text, txt_total_enf.Text)
        lbl_plantel.Text = ListBox1.Text
        Chart_pie.Series("Serie1").Points(0).LegendText = "DISCAPACIDAD"
        Chart_pie.Series("Serie1").Points(1).LegendText = "ADICCION"
        Chart_pie.Series("Serie1").Points(2).LegendText = "ENFERMEDAD"
    End Sub

    Private Sub Chk_vertodo_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_vertodo.CheckedChanged
        If Chk_vertodo.Checked = True Then
            txt_folio.Text = ""
            TxtNombre.Text = ""
            'cb_plantel.SelectedItem = -1
            txt_folio.Enabled = False
            TxtNombre.Enabled = False
            cb_plantel.Enabled = False
        Else
            txt_folio.Enabled = True
            cb_plantel.Enabled = True
            TxtNombre.Enabled = True
        End If

    End Sub

    Private Sub Btn_imprimir_Click(sender As Object, e As EventArgs) Handles Btn_imprimir.Click

        Dim rpt_plantel As New rpt_InfoAlumno
        Dim form As New CRVisor
        Try
            rpt_plantel.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
            rpt_plantel.SetDataSource(DsAlumno)

            form.CrystalReportViewer1.ReportSource = rpt_plantel
            form.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cb_plantel_Committed(sender As Object, e As EventArgs) Handles cb_plantel.SelectionChangeCommitted
        Try
            txt_folio.Text = ""
            'dtTable.Clear()
            DsAlumno.Clear()
            metodos.proc_verPorPlantel("plantel", cb_plantel.Text, DsAlumno)
            Grid_folio.DataSource = DsAlumno.Tables(0)
            Lbl_registros.Text = "Total " & Grid_folio.Rows.Count() & " Registros"
            combo = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabControl_menu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_menu.SelectedIndexChanged
        If TabControl_menu.SelectedTab.Name = "TabPage4" Then
            Try
                metodos.ver_usuarios("", dtTable)
                grid_usuarios.DataSource = dtTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub grid_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_usuarios.CellContentClick
        Try
            If grid_usuarios.Rows(e.RowIndex).Cells(0).Selected Then

                If MessageBox.Show("ESTAS SEGURO DE ELIMINAR ESTE USUARIO?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    metodos.quitar_dela_lista(grid_usuarios.Rows(e.RowIndex).Cells(1).Value)
                    grid_usuarios.Rows.RemoveAt(e.RowIndex)
                End If
            Else
                'nada
            End If
            Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Link_disc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_disc.LinkClicked
        LLENAR_GRID("DISCAPACIDAD")
    End Sub

    Private Sub Link_adic_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_adic.LinkClicked
        LLENAR_GRID("ADICCION")
    End Sub

    Private Sub Link_enf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_enf.LinkClicked
        LLENAR_GRID("ENFERMEDAD")
    End Sub

    Public Sub LLENAR_GRID(ByVal problema As String)
        Try
            metodos.proc_Estadisticas(problema, ListBox1.Text, dtTable)
            grid_estadistica.DataSource = dtTable
        Catch ex As Exception
            MessageBox.Show("hay algun problema con el procedimiento" & ex.Message)
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

    Private Sub BotonImprimir_Click(sender As Object, e As EventArgs) Handles BotonImprimir.Click
        Dim rpt_rectoria As New rpt_Rectoria
        Dim form As New CRVisor
        Try
            rpt_rectoria.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
            rpt_rectoria.SetDataSource(DsAlumno)
            form.CrystalReportViewer1.ReportSource = rpt_rectoria
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CbBuscar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbBuscar.SelectionChangeCommitted
        Try
            DsAlumno.Clear()
            DsAlumno.Tables(0).Columns.Clear()
            metodos.ConsultaRectoria(CbBuscar.Text, DsAlumno)
            GridBuscar.DataSource = DsAlumno.Tables(0)
            LblBuscar.Text = "Total " & GridBuscar.Rows.Count() & " Registros"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_folio_TextChanged(sender As Object, e As EventArgs) Handles txt_folio.TextChanged
        TxtNombre.Text = ""
    End Sub

    Private Sub Button_Exportar_Click(sender As Object, e As EventArgs) Handles Button_Exportar.Click
        Call Rutina.xls(Grid_folio)
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        txt_folio.Text = ""
    End Sub
End Class

