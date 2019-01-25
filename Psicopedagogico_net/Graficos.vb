Imports Datos

Public Class Graficos
    Dim Metodos As New MetodosSQL
    Dim ms = New System.IO.MemoryStream()
    Dim dt As New DataTable
    Dim dtm1 As New DataTable
    Dim dtm2 As New DataTable
    Dim dtm3 As New DataTable
    Dim dtSedes As New DataTable
    Dim var1, var2, var3 As String
    Public cuenta As String
    Dim j As Integer = 0

    Dim ds As New DsGrupos

    Private Sub Graficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '----------------VALIDA USUARIO---------------
            If cuenta = "Consultas_invitado" Then
                'cb_plantel.Items.Clear()
                cb_plantel.DataSource = Consultas_invitado.cb_plantel2.DataSource
                cb_plantel.DisplayMember = "Plantel" 'Consultas_invitado.cb_plantel2.ValueMember
            Else
                'cb_plantel.SelectedItem = "ACAMBARO - ANDADOR JUAREZ"
                cb_tipo_grafica.SelectedItem = "CIRCULAR"
            End If
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Graficos " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub

    Private Sub Btn_Graficar_Click(sender As Object, e As EventArgs) Handles Btn_Graficar.Click
        Try
            'ds.Tables("DtGraficos").Columns.Clear()
            ds.Tables("DtGraficos").Rows.Clear()
            TAB_CONTROL()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub TAB_CONTROL()
        If TabControl1.SelectedTab.Name = "TabPage1" Then

            If ListBox_datos.Text = "" Then
                MessageBox.Show("Selecciona un elemento de la lista", "Generar graficos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            Else

                If Chart_barras.Series.Count > 0 Or Chart_pie.Series.Count > 0 Then
                    Chart_barras.Series("Serie1").Points.Clear()
                    Chart_pie.Series("Serie1").Points.Clear()
                End If
                'ds.Tables("DtGraficos").Columns.Clear()
                'ds.Tables("DtGraficos").Rows.Clear()

                Metodos.obtener_datos_grafica(cb_plantel.Text, ListBox_datos.Text, CbFiltro.Text, ds, DateTimePicker_Inicio.Value.ToShortDateString, DateTimePicker_Final.Value.ToShortDateString)
                If ds.Tables("DtGraficos").Rows.Count > 0 Then
                    grsfico()
                Else
                    MessageBox.Show("No hay datos registrados en el plantel " & cb_plantel.Text, "No hay datos para mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
            '---TAB PAGE 2, 3 ELEMENTOS A GRAFICAR
        Else
            Btn_Graficar.Enabled = False
            If ChkList.Text = "" Then
                MessageBox.Show("Selecciona de uno a tres elemento de la lista", "Generar graficos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            ElseIf ChkList.CheckedItems.Count < 3 Then
                MessageBox.Show("Selecciona 3 elementos a graficar", "Validando datos de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                grafico_multiple()
            End If
        End If

        If grid_datos.RowCount > 0 Then
            grid_datos.Columns(0).HeaderText = "Elemento"
            grid_datos.Columns(1).HeaderText = "Resultado"
            grid_datos.Columns(2).HeaderText = "Cantidad"

            If grid_datos.Columns.Count > 3 Then
                grid_datos.Columns.Remove("Grafica")
            End If
        End If

    End Sub

    Public Sub grafico_multiple()
        Metodos.obtener_datos_multiple(cb_plantel.Text, TextBox1.Text, CbFiltro.Text, dtm1)
        Metodos.obtener_datos_multiple(cb_plantel.Text, TextBox2.Text, CbFiltro.Text, dtm2)
        Metodos.obtener_datos_multiple(cb_plantel.Text, TextBox3.Text, CbFiltro.Text, dtm3)
        Dim cant As Integer = dtm1.Rows.Count
        If cant > 0 Then
            Try

                For i = 0 To dtm1.Rows.Count - 1
                    'Chart_multiple.Series("Series1").Points.AddXY(dtm1.Rows(i)("campo1").ToString & " - " & dtm2.Rows(i)("campo1").ToString & " - " & dtm3.Rows(i)("campo1").ToString, dtm1.Rows(i)("cuantos").ToString)
                    Chart_multiple.Series("Series1").Points.AddXY(dtm1.Rows(i)("campo1").ToString, dtm1.Rows(i)("cuantos").ToString)
                    Chart_multiple.Series("Series1").LegendText = TextBox1.Text
                Next
                For i = 0 To dtm2.Rows.Count - 1
                    Chart_multiple.Series("Series2").Points.AddXY(dtm2.Rows(i)("campo1").ToString, dtm2.Rows(i)("cuantos").ToString)
                    Chart_multiple.Series("Series2").LegendText = TextBox2.Text
                Next
                For i = 0 To dtm3.Rows.Count - 1
                    Chart_multiple.Series("Series3").Points.AddXY(dtm3.Rows(i)("campo1").ToString, dtm3.Rows(i)("cuantos").ToString)
                    Chart_multiple.Series("Series3").LegendText = TextBox3.Text
                Next
                'AGREGAR UN RENGLON QUE SEPARE

                'dtm1.Rows.Add(TextBox2.Text, 0)
                'dtm2.Rows.Add(TextBox3.Text, 0)
                dtm1.Merge(dtm2)
                dtm1.Merge(dtm3)
                grid_datos.DataSource = dtm1
                'grid_datos.Rows(0).Cells(1).Value = TextBox1.Text
                grid_datos.Rows(0).Cells("column1").Value = TextBox1.Text
                grid_datos.Rows(cant).Cells("column1").Value = TextBox2.Text
                grid_datos.Rows(dtm2.Rows.Count + cant).Cells("column1").Value = TextBox3.Text

                'TITULO
                Label_titulo.Visible = True
                txt_titulo.Visible = True
                txt_titulo.Text = ListBox_datos.Text

                'PASAR VALOR DE dt A ds
                Dim fila As Integer = 0
                For Each q In dtm1.Rows
                    ds.Tables("DtGraficos").Rows.Add(dtm1.Rows(fila)(0), dtm1.Rows(fila)(1))
                    fila += 1
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("No hay datos registrados en el plantel " & cb_plantel.Text, "No hay datos para mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub grsfico()
        Try
            Dim i As Integer = 0
            grid_datos.DataSource = ds.Tables("DtGraficos")

            If cb_tipo_grafica.SelectedItem = "CIRCULAR" Then

                Chart_barras.Visible = False
                Chart_pie.DataSource = ds
                For i = 0 To ds.Tables("DtGraficos").Rows.Count - 1
                    Chart_pie.Series("Serie1").Points.AddXY(ds.Tables("DtGraficos").Rows(i)("cuantos").ToString, ds.Tables("DtGraficos").Rows(i)("cuantos").ToString)
                    Chart_pie.Series("Serie1").Points(i).LegendText = ds.Tables("DtGraficos").Rows(i)("campo1").ToString
                    grid_datos.Rows(0).Cells("column1").Value = ListBox_datos.Text
                Next
            Else
                Chart_barras.DataSource = ds
                For i = 0 To ds.Tables("DtGraficos").Rows.Count - 1
                    Chart_barras.Series("Serie1").Points.AddXY(ds.Tables("DtGraficos").Rows(i)("campo1").ToString, ds.Tables("DtGraficos").Rows(i)("cuantos").ToString)
                    grid_datos.Rows(0).Cells("column1").Value = ListBox_datos.Text
                Next
                Chart_barras.Visible = True
                ' Chart_barras.Titles.Add(txt_titulo.Text)
            End If
            'TITULO
            Label_titulo.Visible = True
            txt_titulo.Visible = True
            txt_titulo.Text = ListBox_datos.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub GRAFICO_VARIABLE()

        Metodos.obtener_datos_multiple2(cb_plantel.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, dtm1, var1, var2, var3)
        For i = 0 To dtm1.Rows.Count - 1
            Chart_multiple.Series("Series1").Points.AddXY(dtm1.Rows(i)("campo1").ToString & " - " & dtm1.Rows(i)("campo2").ToString & " - " & dtm1.Rows(i)("campo3").ToString, dtm1.Rows(i)("cuantos").ToString)
            'Chart_multiple.Series("Series1").Points.AddXY(dtm1.Rows(i)("campo1").ToString, dtm1.Rows(i)("cuantos").ToString)
            Chart_multiple.Series("Series1").LegendText = TextBox1.Text
        Next
        For i = 0 To dtm1.Rows.Count - 1
            Chart_multiple.Series("Series2").Points.AddXY(dtm1.Rows(i)("campo2").ToString, dtm1.Rows(i)("cuantos").ToString)
            Chart_multiple.Series("Series2").LegendText = TextBox2.Text
        Next
        For i = 0 To dtm1.Rows.Count - 1
            Chart_multiple.Series("Series3").Points.AddXY(dtm1.Rows(i)("campo3").ToString, dtm1.Rows(i)("cuantos").ToString)
            Chart_multiple.Series("Series3").LegendText = TextBox3.Text
        Next
    End Sub

    Private Sub Btn_descartar_Click(sender As Object, e As EventArgs) Handles Btn_descartar.Click
        Chart_pie.Series("Serie1").Points.Clear()
        Chart_barras.Series("Serie1").Points.Clear()
        ds.Tables("DtGraficos").Rows.Clear()
        Label_titulo.Visible = False
        txt_titulo.Visible = False
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        ' If txt_titulo.Visible = True Then
        If TabControl1.SelectedTab.Name = "TabPage1" And ds.Tables("DtGraficos").Rows.Count > 0 Then
            guardar()
        ElseIf TabControl1.SelectedTab.Name = "TabPage2" And dtm1.Rows.Count > 0 Then
            guardar_multichart()
            'End If
            Me.BringToFront()
        Else
            MessageBox.Show("No hay grafico para guardar", "Generar graficos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub guardar()
        Try
            SaveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
            Chart_barras.Titles.Clear()
            Chart_pie.Titles.Clear()

            If Chart_barras.Visible = True Then
                Chart_barras.Titles.Add(txt_titulo.Text)

                Dim Barras As New Bitmap(Chart_barras.Width, Chart_barras.Height)
                Chart_barras.DrawToBitmap(Barras, Chart_barras.DisplayRectangle)
                SaveFileDialog1.ShowDialog()
                Dim file As String

                If SaveFileDialog1.FileName = "" Then
                    'nada
                Else
                    file = SaveFileDialog1.FileName
                    Barras.Save(file)
                End If

            Else
                Chart_pie.Titles.Add(txt_titulo.Text)
                Dim pie As New Bitmap(Chart_pie.Width, Chart_pie.Height)
                Chart_pie.DrawToBitmap(pie, Chart_pie.DisplayRectangle)
                SaveFileDialog1.ShowDialog()
                Dim file As String

                If SaveFileDialog1.FileName = "" Then
                    'nada
                Else
                    file = SaveFileDialog1.FileName
                    pie.Save(file)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub guardar_multichart()
        Try
            SaveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
            Chart_barras.Titles.Clear()
            Chart_pie.Titles.Clear()

            Chart_multiple.Titles.Add(txt_titulo.Text)
            Chart_pie.Titles.Add(txt_titulo.Text)
            Dim multi As New Bitmap(Chart_multiple.Width, Chart_multiple.Height)
            Chart_multiple.DrawToBitmap(multi, Chart_multiple.DisplayRectangle)
            SaveFileDialog1.ShowDialog()
            Dim file As String

            If SaveFileDialog1.FileName = "" Then
                'nada
            Else
                file = SaveFileDialog1.FileName
                multi.Save(file)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Btn_imprimir_Click(sender As Object, e As EventArgs) Handles Btn_imprimir.Click
        Dim cr As New rpt_Graficos_Barra
        Dim form As New CRVisor
        ms = New System.IO.MemoryStream()

        'PINTAR GRAFICA CHART XAREA
        If TabControl1.SelectedTab.Name = "TabPage2" Then

            'Chart_multiple.Titles.Add(txt_titulo.Text)
            Dim multi As New Bitmap(Chart_multiple.Width, Chart_multiple.Height)
            Chart_multiple.DrawToBitmap(multi, Chart_multiple.DisplayRectangle)
            multi.Save(ms, Imaging.ImageFormat.Bmp)

        ElseIf cb_tipo_grafica.Text = "BARRAS" Then

            Dim Barras As New Bitmap(Chart_barras.Width, Chart_barras.Height)
            Chart_barras.DrawToBitmap(Barras, Chart_barras.DisplayRectangle)
            Barras.Save(ms, Imaging.ImageFormat.Bmp)

        Else
            'Chart_pie.Titles.Add(txt_titulo.Text)
            Dim pie As New Bitmap(Chart_pie.Width, Chart_pie.Height)
            Chart_pie.DrawToBitmap(pie, Chart_pie.DisplayRectangle)
            pie.Save(ms, Imaging.ImageFormat.Bmp)
        End If

        'CONVERTIR A BITE
        Dim arrImage() As Byte = ms.GetBuffer
        '-GUARDANDO EN DATASET
        Dim i As Integer = 0
        For i = 0 To i = ds.Tables("DtGraficos").Rows.Count()
            ds.Tables("DtGraficos").Rows(i)(2) = arrImage
        Next

        cr.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
        cr.SetDataSource(ds)
        cr.SetParameterValue("Titulo", txt_titulo.Text)
        form.CrystalReportViewer1.ReportSource = cr
        form.Show()

        'PRINT DOCUMENT
        'Try
        '    If TabControl1.SelectedTab.Name = "TabPage1" And dt.Rows.Count = 0 Then
        '        MessageBox.Show("No hay grafico para imprimir", "Generar graficos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        '    ElseIf TabControl1.SelectedTab.Name = "TabPage2" And dtm1.Rows.Count = 0 Then
        '        MessageBox.Show("No hay grafico para imprimir", "Generar graficos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        '    Else
        '        'VISTA PREVIA
        '        PrintPreviewDialog1.ShowDialog(Me)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Generar graficos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
        Try
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintPreviewDialog1.Document = PrintDocument1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Generar graficos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim tam As New Printing.PaperSize("Letter", 850, 1100)
            PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize = tam
        Catch ex As Exception
            MessageBox.Show("print print")
        End Try


        Try
            Dim Barras As New Bitmap(Chart_barras.Width, Chart_barras.Height)
            Chart_barras.DrawToBitmap(Barras, Chart_barras.DisplayRectangle)

            Dim pie As New Bitmap(Chart_pie.Width, Chart_pie.Height)
            Chart_pie.DrawToBitmap(pie, Chart_pie.DisplayRectangle)

            Dim multi As New Bitmap(Chart_multiple.Width, Chart_multiple.Height)
            Chart_multiple.DrawToBitmap(multi, Chart_multiple.DisplayRectangle)

            Dim Fuente As New Font("Calibri", 12, FontStyle.Regular)
            Dim Fuente_Encabezado As New Font("Calibri", 12, FontStyle.Bold)
            Dim Color As Brush = New SolidBrush(Drawing.Color.Black)
            Dim Lugar_titulo As New PointF(170, 50)        '--150
            Dim Lugar_plantel As New PointF(170, 80)
            Dim drawFormat As New System.Drawing.StringFormat

            'Dim logo As Image = Psicopedagogico_net.My.Resources.vidas
            Dim logo As Image = Psicopedagogico_net.My.Resources.logo_psicop
            Dim Des_Integral As Image = Psicopedagogico_net.My.Resources.xx
            e.Graphics.DrawString(txt_titulo.Text, Fuente, Color, Lugar_titulo, drawFormat)
            e.Graphics.DrawString("PLANTEL: " & cb_plantel.Text, Fuente_Encabezado, Color, Lugar_plantel, drawFormat)
            e.Graphics.DrawImage(logo, 3, 10, 160, 80)    '100,90
            e.Graphics.DrawImage(Des_Integral, 630, 20, 180, 60)

            If TabControl1.SelectedTab.Name = "TabPage1" Then
                If Chart_barras.Visible = True Then
                    e.Graphics.DrawImage(Barras, 20, 110, 630, 400) 'Barras, 100, 200, 600, 500
                Else
                    e.Graphics.DrawImage(pie, 20, 110, 850, 400)    'pie, 20, 200, 820, 400
                End If
            Else
                e.Graphics.DrawImage(multi, 20, 110, 820, 400)  '20, 200, 820, 400
            End If

            '--IMPRIMIR GRID
            Dim row As System.Windows.Forms.DataGridViewRow
            Dim texto As String = ""
            Dim encabezado As String = ""
            Dim Lugar_Tabla As New PointF(100, 510) '100, 600

            While j < grid_datos.Rows.Count
                row = grid_datos.Rows(j)
                For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                    '
                    If celda.Value IsNot Nothing Then
                        If celda.ColumnIndex = 0 Then
                            encabezado += vbTab + celda.Value.ToString() + vbCrLf

                            e.Graphics.DrawString(encabezado, Fuente_Encabezado, Color, Lugar_Tabla, drawFormat)
                            texto += vbCrLf
                        Else
                            'texto += vbTab + celda.Value.ToString()     '--numero (cantidad)
                            texto += vbTab + celda.Value.ToString() + "     " + vbTab
                        End If
                    End If
                Next

                texto += vbCrLf
                encabezado += vbCrLf
                e.Graphics.DrawString(texto, Fuente, Color, Lugar_Tabla, drawFormat)
                'e.Graphics.DrawString(texto, Fuente, Color, Lugar_Tabla, drawFormat)

                j = j + 1

                If j = 20 Or j = 40 Then     '--If j = 10 Or j = 37 Then    
                    Exit While
                End If

            End While

            If (j > 10 And j < grid_datos.Rows.Count) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                j = 0
            End If

            'Dim Lugarx As New PointF(80, 520)
            'e.Graphics.DrawString("PLANTEL: " & cb_plantel.Text, Fuente_Encabezado, Color, Lugarx, drawFormat)

        Catch ex As Exception
            MessageBox.Show(ex.Message & "Comuníquese con el administrador del sistema", "EXCEPCION DEL SISTEMA", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ChkList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChkList.SelectedIndexChanged

        Select Case ChkList.CheckedItems.Count
            Case 1
                TextBox1.Text = ChkList.Text
            Case 2
                'var1 = txt_valiable.Text
                'txt_valiable.Text = ""
                TextBox2.Text = ChkList.Text
            Case 3
                'var2 = txt_valiable.Text
                'txt_valiable.Text = ""
                TextBox3.Text = ChkList.Text
                ChkList.Enabled = False
                Btn_Graficar.Enabled = True
        End Select

    End Sub

    Private Sub CbFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbFiltro.SelectionChangeCommitted
        Try

            If CbFiltro.Text = "TODO" Then
                cb_plantel.Enabled = False
            Else

                cb_plantel.Enabled = True

                If CbFiltro.Text = "PLANTEL" Then
                    Metodos.CargarSedes(dtSedes)
                    cb_plantel.DataSource = dtSedes
                    cb_plantel.DisplayMember = "Sede"
                Else
                    Metodos.ciudades(dtSedes)
                    cb_plantel.DataSource = dtSedes
                    cb_plantel.DisplayMember = "Ciudad"
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & "Comuníquese con el administrador del sistema", "EXCEPCION DEL SISTEMA",
                            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Btn_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_nuevo.Click
        Dim i As Integer
        For i = 0 To (ChkList.Items.Count - 1) 'Listbox is the listbox's name
            ChkList.SetItemChecked(i, False)
        Next
        If Chart_multiple.Series("Series1").Points.Count > 0 Then
            Chart_multiple.Series("Series1").Points.Clear()
            Chart_multiple.Series("Series2").Points.Clear()
            Chart_multiple.Series("Series3").Points.Clear()
        End If

        ChkList.Enabled = True
        dtm1.Columns.Clear()
        dtm1.Rows.Clear()
        dtm2.Columns.Clear()
        dtm2.Rows.Clear()
        dtm3.Columns.Clear()
        dtm3.Rows.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Btn_Graficar.Enabled = True
        Me.BringToFront()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Name = "TabPage1" Then
            Chart_multiple.Visible = False
            Label_tipoGrafica.Visible = True
            cb_tipo_grafica.Visible = True
            Btn_Graficar.Enabled = True
        Else
            Chart_multiple.Visible = True
            Label_tipoGrafica.Visible = False
            cb_tipo_grafica.Visible = False
            Btn_Graficar.Enabled = False
        End If
        grid_datos.DataSource = ""

    End Sub

End Class