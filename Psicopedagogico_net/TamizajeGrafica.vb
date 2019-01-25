Imports Datos

Public Class TamizajeGrafica
    Dim Metodos As New MetodosSQL
    Dim dt As New DataTable
    Dim Grup As New Consulta_Grupos
    Dim ms = New System.IO.MemoryStream()

    Private Sub TamizajeGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Metodos.CargarSedes(dt)
            Metodos.ConsultaVariable(dt, "PLANTEL", "Ps_Tamizaje", "")
            CBPlantel.DataSource = dt
            'CBPlantel.DisplayMember = "Plantel"
            CBPlantel.ValueMember = "Plantel"
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario TamizajeGrafica " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub

    Private Sub BtnGraficar_Click(sender As Object, e As EventArgs) Handles BtnGraficar.Click
        Try
            Grup.DsGrupos.Tables("DtTamizaje").Clear()

            Metodos.consultarTamizaje(Grup.DsGrupos, CBPlantel.Text)
            Dim Factor As String = ""
            Dim Valor As Integer = 0
            Dim dtFactor As New DataTable
            Dim Filas As Integer = 0

            'converiones a columnas de tablas en BD
            If CBFactor.Text = "RIESGO SUICIDA" Then
                Factor = "RiesgoSuicida"
            ElseIf CBFactor.Text = "VIOLENCIA EN ADOLESCENTES" Then
                Factor = "Violencia"
            ElseIf CBFactor.Text = "CONSUMO DE SUSTANCIAS" Then
                Factor = "Sustancias"
            ElseIf CBFactor.Text = "CONDUCTAS ALIM. DE RIESGO" Then
                Factor = "ConductasAlim"
            Else
                Factor = CBFactor.Text
            End If

            Metodos.GraficaRTamizaje(dtFactor, Factor, CBPlantel.Text)
            Filas = dtFactor.Rows.Count()
            Chart1.Series("Series1").Points.Clear()

            If DUpGrafica.Text = "BARRAS" Then
                Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            ElseIf DUpGrafica.Text = "COLUMNAS" Then
                Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Column
            ElseIf DUpGrafica.Text = "LINEAS" Then
                Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line
            ElseIf DUpGrafica.Text = "PUNTOS" Then
                Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Point
            ElseIf DUpGrafica.Text = "CIRCULAR" Then
                Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Pie
            ElseIf DUpGrafica.Text = "DONA" Then
                Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
            End If


            For i As Integer = 0 To Filas - 1
                Factor = dtFactor.Rows(i)("Factor").ToString
                Valor = dtFactor.Rows(i)("Total")
                Chart1.Series("Series1").Points.AddXY("Factor", "Valor")
                Chart1.Series("Series1").Points(i).SetValueXY(Factor & " - " & Valor, Valor)
                'Chart1.Series("Series1").Points(i).IsValueShownAsLabel = True
            Next
            Chart1.Series("Series1").LegendText = CBFactor.Text
            GridGrafica.DataSource = dtFactor
            LabelFactor.Text = CBFactor.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CBPlantel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPlantel.SelectionChangeCommitted

        Try
            Grup.DsGrupos.Tables("DtTamizaje").Clear()

            Metodos.ConsultaVariable(dt, "GRUPO", "Ps_Tamizaje", CBPlantel.Text)
            ' Metodos.consultarTamizaje(Grup.DsGrupos, CBPlantel.Text)
            CBGrupo.DataSource = dt

            CBGrupo.ValueMember = "Grupo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            Grup.DsGrupos.Tables("DtGraficaTamiz").Clear()
            'DIBUJAR GRAFICO
            Dim PaintGrafico As New Bitmap(Chart1.Width, Chart1.Height)
            Chart1.DrawToBitmap(PaintGrafico, Chart1.DisplayRectangle)
            'CONVERTIR A BYTE
            PaintGrafico.Save(ms, Imaging.ImageFormat.Bmp)
            Dim arrImage() As Byte = ms.GetBuffer

            'GUARDAR RENGLON EN DATASET
            Dim Fila As DataRow = Grup.DsGrupos.Tables("DtGraficaTamiz").NewRow
            Fila("PLANTEL") = CBPlantel.Text
            Fila("GRUPO") = CBGrupo.Text
            Fila("FACTOR") = CBFactor.Text
            Fila("GRAFICA") = arrImage
            For i As Integer = 0 To GridGrafica.RowCount - 1
                Fila("VALOR") = GridGrafica.Rows(i).Cells("Factor").Value
                Fila("TOTAL") = GridGrafica.Rows(i).Cells("Total").Value

                Grup.DsGrupos.Tables("DtGraficaTamiz").Rows.Add(Fila)
                Fila = Grup.DsGrupos.Tables("DtGraficaTamiz").NewRow
            Next

            Dim cr As New rpt_TamizajeGrafica
            Dim visor As New CRVisor
            cr.SetDatabaseLogon("", "")
            cr.SetDataSource(Grup.DsGrupos.Tables("DtGraficaTamiz"))
            visor.CrystalReportViewer1.ReportSource = cr
            visor.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class