<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Graficos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Graficos))
        Me.cb_plantel = New System.Windows.Forms.ComboBox()
        Me.ChkList = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Selecciona = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbFiltro = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox_datos = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Btn_nuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_titulo = New System.Windows.Forms.Label()
        Me.Chart_multiple = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Chart_barras = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_pie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grid_datos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label_tipoGrafica = New System.Windows.Forms.Label()
        Me.cb_tipo_grafica = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Btn_Graficar = New System.Windows.Forms.Button()
        Me.Btn_imprimir = New System.Windows.Forms.Button()
        Me.Btn_descartar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Final = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart_multiple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_barras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_pie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_plantel
        '
        Me.cb_plantel.DropDownHeight = 130
        Me.cb_plantel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plantel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_plantel.FormattingEnabled = True
        Me.cb_plantel.IntegralHeight = False
        Me.cb_plantel.Location = New System.Drawing.Point(3, 66)
        Me.cb_plantel.Name = "cb_plantel"
        Me.cb_plantel.Size = New System.Drawing.Size(241, 23)
        Me.cb_plantel.TabIndex = 1
        '
        'ChkList
        '
        Me.ChkList.CheckOnClick = True
        Me.ChkList.FormattingEnabled = True
        Me.ChkList.Items.AddRange(New Object() {"GRADO", "ESPECIALIDAD", "TURNO", "DISCAPACIDAD", "ADICCION", "ENFERMEDAD", "TRABAJA", "SEXO", "P_VIVE", "P_EDAD", "P_GRADO", "P_EDOCIVIL", "P_DISCAPACIDAD", "P_ADICCION", "P_ENFERMEDAD", "P_TRABAJA", "M_VIVE", "M_EDAD", "M_GRADO", "M_EDOCIVIL", "M_DISCAPACIDAD", "M_ADICCION", "M_ENFERMEDAD", "M_TRABAJA", "HERMANOS", "MOTIVO_CONSULTA", "MOTIVO_CAN", "LUGAR_CAN", "ATENCION", "UNIDAD", "VIOLENCIA", "CONSUMO_SUSTANCIAS", "DEPRESION", "TRANSTORNOS_ALIMENTACION", "DEFICIT_ATENCION", "INTERVENCION_CRISIS"})
        Me.ChkList.Location = New System.Drawing.Point(2, 6)
        Me.ChkList.Name = "ChkList"
        Me.ChkList.Size = New System.Drawing.Size(245, 290)
        Me.ChkList.TabIndex = 2
        Me.ChkList.ThreeDCheckBoxes = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Lbl_Selecciona)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CbFiltro)
        Me.Panel1.Controls.Add(Me.cb_plantel)
        Me.Panel1.Location = New System.Drawing.Point(13, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 97)
        Me.Panel1.TabIndex = 10
        '
        'Lbl_Selecciona
        '
        Me.Lbl_Selecciona.AutoSize = True
        Me.Lbl_Selecciona.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Selecciona.Location = New System.Drawing.Point(3, 48)
        Me.Lbl_Selecciona.Name = "Lbl_Selecciona"
        Me.Lbl_Selecciona.Size = New System.Drawing.Size(72, 15)
        Me.Lbl_Selecciona.TabIndex = 12
        Me.Lbl_Selecciona.Text = "SELECCIONA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "SELECCIONA EL FILTRO"
        '
        'CbFiltro
        '
        Me.CbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFiltro.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFiltro.FormattingEnabled = True
        Me.CbFiltro.Items.AddRange(New Object() {"TODO", "CIUDAD", "PLANTEL"})
        Me.CbFiltro.Location = New System.Drawing.Point(3, 21)
        Me.CbFiltro.Name = "CbFiltro"
        Me.CbFiltro.Size = New System.Drawing.Size(242, 23)
        Me.CbFiltro.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 242)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(249, 388)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox_datos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(241, 356)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Un Elemento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox_datos
        '
        Me.ListBox_datos.FormattingEnabled = True
        Me.ListBox_datos.ItemHeight = 19
        Me.ListBox_datos.Items.AddRange(New Object() {"EDAD", "GRADO", "ESPECIALIDAD", "TURNO", "DISCAPACIDAD", "ADICCION", "ENFERMEDAD", "TRABAJA", "SEXO", "P_VIVE", "P_EDAD", "P_GRADO", "P_EDOCIVIL", "P_DISCAPACIDAD", "P_ADICCION", "P_ENFERMEDAD", "P_TRABAJA", "M_VIVE", "M_EDAD", "M_GRADO", "M_EDOCIVIL", "M_DISCAPACIDAD", "M_ADICCION", "M_ENFERMEDAD", "M_TRABAJA", "HERMANOS", "MOTIVO_CONSULTA", "MOTIVO_CAN", "LUGAR_CAN", "ATENCION", "UNIDAD", "VIOLENCIA", "CONSUMO_SUSTANCIAS", "DEPRESION", "TRANSTORNOS_ALIMENTACION", "DEFICIT_ATENCION", "INTERVENCION_CRISIS"})
        Me.ListBox_datos.Location = New System.Drawing.Point(3, 3)
        Me.ListBox_datos.Name = "ListBox_datos"
        Me.ListBox_datos.Size = New System.Drawing.Size(245, 346)
        Me.ListBox_datos.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Btn_nuevo)
        Me.TabPage2.Controls.Add(Me.ChkList)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(241, 356)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tres elementos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Btn_nuevo
        '
        Me.Btn_nuevo.Image = Global.Psicopedagogico_net.My.Resources.Resources.refresh
        Me.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_nuevo.Location = New System.Drawing.Point(30, 302)
        Me.Btn_nuevo.Name = "Btn_nuevo"
        Me.Btn_nuevo.Size = New System.Drawing.Size(162, 40)
        Me.Btn_nuevo.TabIndex = 13
        Me.Btn_nuevo.Text = "Nueva Búsqueda"
        Me.Btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "DATOS A GRAFICAR"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label_titulo)
        Me.Panel3.Controls.Add(Me.Chart_multiple)
        Me.Panel3.Controls.Add(Me.txt_titulo)
        Me.Panel3.Controls.Add(Me.Chart_barras)
        Me.Panel3.Controls.Add(Me.Chart_pie)
        Me.Panel3.Location = New System.Drawing.Point(277, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(788, 376)
        Me.Panel3.TabIndex = 12
        '
        'Label_titulo
        '
        Me.Label_titulo.AutoSize = True
        Me.Label_titulo.Location = New System.Drawing.Point(145, 19)
        Me.Label_titulo.Name = "Label_titulo"
        Me.Label_titulo.Size = New System.Drawing.Size(57, 19)
        Me.Label_titulo.TabIndex = 76
        Me.Label_titulo.Text = "TITULO"
        Me.Label_titulo.Visible = False
        '
        'Chart_multiple
        '
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart_multiple.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_multiple.Legends.Add(Legend1)
        Me.Chart_multiple.Location = New System.Drawing.Point(20, 44)
        Me.Chart_multiple.Name = "Chart_multiple"
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Me.Chart_multiple.Series.Add(Series1)
        Me.Chart_multiple.Series.Add(Series2)
        Me.Chart_multiple.Series.Add(Series3)
        Me.Chart_multiple.Size = New System.Drawing.Size(737, 325)
        Me.Chart_multiple.TabIndex = 80
        Me.Chart_multiple.Text = "Chart1"
        Me.Chart_multiple.Visible = False
        '
        'txt_titulo
        '
        Me.txt_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_titulo.Location = New System.Drawing.Point(208, 16)
        Me.txt_titulo.MaxLength = 45
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(353, 27)
        Me.txt_titulo.TabIndex = 4
        Me.txt_titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_titulo.Visible = False
        '
        'Chart_barras
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart_barras.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart_barras.Legends.Add(Legend2)
        Me.Chart_barras.Location = New System.Drawing.Point(10, 49)
        Me.Chart_barras.Name = "Chart_barras"
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.Purple
        Series4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.IsVisibleInLegend = False
        Series4.IsXValueIndexed = True
        Series4.Legend = "Legend1"
        Series4.MarkerColor = System.Drawing.Color.Navy
        Series4.Name = "Serie1"
        Me.Chart_barras.Series.Add(Series4)
        Me.Chart_barras.Size = New System.Drawing.Size(737, 302)
        Me.Chart_barras.TabIndex = 77
        Me.Chart_barras.Text = "Chart_grafico"
        Title1.Name = "Title1"
        Me.Chart_barras.Titles.Add(Title1)
        Me.Chart_barras.Visible = False
        '
        'Chart_pie
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart_pie.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart_pie.Legends.Add(Legend3)
        Me.Chart_pie.Location = New System.Drawing.Point(-2, 49)
        Me.Chart_pie.Name = "Chart_pie"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.Legend = "Legend1"
        Series5.Name = "Serie1"
        Me.Chart_pie.Series.Add(Series5)
        Me.Chart_pie.Size = New System.Drawing.Size(749, 325)
        Me.Chart_pie.TabIndex = 74
        Me.Chart_pie.Text = "Chart1"
        Title2.Name = "Titlo"
        Me.Chart_pie.Titles.Add(Title2)
        '
        'grid_datos
        '
        Me.grid_datos.AllowUserToAddRows = False
        Me.grid_datos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grid_datos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_datos.BackgroundColor = System.Drawing.Color.White
        Me.grid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.grid_datos.GridColor = System.Drawing.Color.White
        Me.grid_datos.Location = New System.Drawing.Point(277, 429)
        Me.grid_datos.Name = "grid_datos"
        Me.grid_datos.ReadOnly = True
        Me.grid_datos.ShowEditingIcon = False
        Me.grid_datos.Size = New System.Drawing.Size(788, 201)
        Me.grid_datos.TabIndex = 81
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Label_tipoGrafica
        '
        Me.Label_tipoGrafica.AutoSize = True
        Me.Label_tipoGrafica.Location = New System.Drawing.Point(1095, 62)
        Me.Label_tipoGrafica.Name = "Label_tipoGrafica"
        Me.Label_tipoGrafica.Size = New System.Drawing.Size(107, 19)
        Me.Label_tipoGrafica.TabIndex = 79
        Me.Label_tipoGrafica.Text = "Tipo de Gráfica"
        '
        'cb_tipo_grafica
        '
        Me.cb_tipo_grafica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo_grafica.FormattingEnabled = True
        Me.cb_tipo_grafica.Items.AddRange(New Object() {"BARRAS", "CIRCULAR"})
        Me.cb_tipo_grafica.Location = New System.Drawing.Point(1096, 88)
        Me.cb_tipo_grafica.Name = "cb_tipo_grafica"
        Me.cb_tipo_grafica.Size = New System.Drawing.Size(113, 27)
        Me.cb_tipo_grafica.TabIndex = 78
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkMagenta
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1242, 31)
        Me.ToolStrip1.TabIndex = 67
        Me.ToolStrip1.Text = "Titulo"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(237, 28)
        Me.ToolStripLabel2.Text = "GENERADOR DE GRAFICAS"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1121, 334)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 27)
        Me.TextBox1.TabIndex = 68
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1121, 352)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(81, 27)
        Me.TextBox2.TabIndex = 69
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1121, 366)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(81, 27)
        Me.TextBox3.TabIndex = 70
        Me.TextBox3.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 648)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1242, 22)
        Me.StatusStrip1.TabIndex = 80
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.Psicopedagogico_net.My.Resources.Resources.save
        Me.btn_guardar.Location = New System.Drawing.Point(1096, 242)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(113, 40)
        Me.btn_guardar.TabIndex = 5
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Btn_Graficar
        '
        Me.Btn_Graficar.Image = CType(resources.GetObject("Btn_Graficar.Image"), System.Drawing.Image)
        Me.Btn_Graficar.Location = New System.Drawing.Point(1096, 150)
        Me.Btn_Graficar.Name = "Btn_Graficar"
        Me.Btn_Graficar.Size = New System.Drawing.Size(113, 40)
        Me.Btn_Graficar.TabIndex = 3
        Me.Btn_Graficar.Text = "Graficar"
        Me.Btn_Graficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Graficar.UseVisualStyleBackColor = True
        '
        'Btn_imprimir
        '
        Me.Btn_imprimir.Image = Global.Psicopedagogico_net.My.Resources.Resources.print
        Me.Btn_imprimir.Location = New System.Drawing.Point(1096, 288)
        Me.Btn_imprimir.Name = "Btn_imprimir"
        Me.Btn_imprimir.Size = New System.Drawing.Size(113, 40)
        Me.Btn_imprimir.TabIndex = 6
        Me.Btn_imprimir.Text = "Imprimir"
        Me.Btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_imprimir.UseVisualStyleBackColor = True
        '
        'Btn_descartar
        '
        Me.Btn_descartar.Image = Global.Psicopedagogico_net.My.Resources.Resources.cancel
        Me.Btn_descartar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_descartar.Location = New System.Drawing.Point(1096, 196)
        Me.Btn_descartar.Name = "Btn_descartar"
        Me.Btn_descartar.Size = New System.Drawing.Size(113, 40)
        Me.Btn_descartar.TabIndex = 7
        Me.Btn_descartar.Text = "Descartar"
        Me.Btn_descartar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_descartar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Inicio)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Final)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 79)
        Me.GroupBox1.TabIndex = 419
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'DateTimePicker_Inicio
        '
        Me.DateTimePicker_Inicio.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Inicio.Location = New System.Drawing.Point(94, 19)
        Me.DateTimePicker_Inicio.Name = "DateTimePicker_Inicio"
        Me.DateTimePicker_Inicio.Size = New System.Drawing.Size(113, 23)
        Me.DateTimePicker_Inicio.TabIndex = 407
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(44, 23)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 15)
        Me.Label32.TabIndex = 409
        Me.Label32.Text = "Inicio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(48, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 15)
        Me.Label16.TabIndex = 410
        Me.Label16.Text = "Final"
        '
        'DateTimePicker_Final
        '
        Me.DateTimePicker_Final.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Final.Location = New System.Drawing.Point(94, 48)
        Me.DateTimePicker_Final.Name = "DateTimePicker_Final"
        Me.DateTimePicker_Final.Size = New System.Drawing.Size(113, 23)
        Me.DateTimePicker_Final.TabIndex = 408
        '
        'Graficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1242, 670)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label_tipoGrafica)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_tipo_grafica)
        Me.Controls.Add(Me.grid_datos)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Btn_Graficar)
        Me.Controls.Add(Me.Btn_imprimir)
        Me.Controls.Add(Me.Btn_descartar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Graficos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graficos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart_multiple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_barras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_pie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_plantel As System.Windows.Forms.ComboBox
    Friend WithEvents ChkList As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Chart_pie As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Btn_Graficar As System.Windows.Forms.Button
    Friend WithEvents Btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Btn_descartar As System.Windows.Forms.Button
    Friend WithEvents Label_titulo As System.Windows.Forms.Label
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents ListBox_datos As System.Windows.Forms.ListBox
    Friend WithEvents Chart_barras As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cb_tipo_grafica As System.Windows.Forms.ComboBox
    Friend WithEvents Label_tipoGrafica As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Chart_multiple As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents grid_datos As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents CbFiltro As ComboBox
    Friend WithEvents Lbl_Selecciona As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Final As System.Windows.Forms.DateTimePicker
End Class
