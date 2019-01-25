<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas_invitado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultas_invitado))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl_principal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart_pie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grid_estadistica = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_total_adic = New System.Windows.Forms.TextBox()
        Me.txt_total_disc = New System.Windows.Forms.TextBox()
        Me.Link_Enfermedad = New System.Windows.Forms.LinkLabel()
        Me.Link_discapacidad = New System.Windows.Forms.LinkLabel()
        Me.Link_Adiccion = New System.Windows.Forms.LinkLabel()
        Me.txt_total_enf = New System.Windows.Forms.TextBox()
        Me.cb_plantel = New System.Windows.Forms.ComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Btn_sintesis = New System.Windows.Forms.Button()
        Me.Btn_Graficar = New System.Windows.Forms.Button()
        Me.cb_plantel2 = New System.Windows.Forms.ComboBox()
        Me.Lbl_registros = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_imprimir = New System.Windows.Forms.Button()
        Me.Chk_vertodo = New System.Windows.Forms.CheckBox()
        Me.Grid_folio = New System.Windows.Forms.DataGridView()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DsAlumno = New Psicopedagogico_net.DsAlumno()
        Me.DsAlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Final = New System.Windows.Forms.DateTimePicker()
        Me.TabControl_principal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart_pie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_estadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grid_folio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_principal
        '
        Me.TabControl_principal.Controls.Add(Me.TabPage1)
        Me.TabControl_principal.Controls.Add(Me.TabPage2)
        Me.TabControl_principal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl_principal.Location = New System.Drawing.Point(1, 0)
        Me.TabControl_principal.Name = "TabControl_principal"
        Me.TabControl_principal.SelectedIndex = 0
        Me.TabControl_principal.Size = New System.Drawing.Size(1263, 623)
        Me.TabControl_principal.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.grid_estadistica)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1255, 591)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "ESTADISTICAS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkMagenta
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1255, 44)
        Me.ToolStrip1.TabIndex = 77
        Me.ToolStrip1.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(290, 41)
        Me.ToolStripLabel1.Text = "ESTADISTICAS DE CANALIZACION"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Chart_pie)
        Me.Panel2.Location = New System.Drawing.Point(636, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(610, 239)
        Me.Panel2.TabIndex = 76
        '
        'Chart_pie
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart_pie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_pie.Legends.Add(Legend1)
        Me.Chart_pie.Location = New System.Drawing.Point(24, 11)
        Me.Chart_pie.Name = "Chart_pie"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Serie1"
        Me.Chart_pie.Series.Add(Series1)
        Me.Chart_pie.Size = New System.Drawing.Size(462, 226)
        Me.Chart_pie.TabIndex = 74
        Me.Chart_pie.Text = "Chart1"
        '
        'grid_estadistica
        '
        Me.grid_estadistica.AllowUserToAddRows = False
        Me.grid_estadistica.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.grid_estadistica.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_estadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grid_estadistica.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grid_estadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_estadistica.GridColor = System.Drawing.SystemColors.Control
        Me.grid_estadistica.Location = New System.Drawing.Point(5, 302)
        Me.grid_estadistica.Name = "grid_estadistica"
        Me.grid_estadistica.ReadOnly = True
        Me.grid_estadistica.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grid_estadistica.Size = New System.Drawing.Size(1241, 279)
        Me.grid_estadistica.TabIndex = 71
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.cb_plantel)
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_total)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 239)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.txt_total_adic)
        Me.Panel3.Controls.Add(Me.txt_total_disc)
        Me.Panel3.Controls.Add(Me.Link_Enfermedad)
        Me.Panel3.Controls.Add(Me.Link_discapacidad)
        Me.Panel3.Controls.Add(Me.Link_Adiccion)
        Me.Panel3.Controls.Add(Me.txt_total_enf)
        Me.Panel3.Location = New System.Drawing.Point(3, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(605, 109)
        Me.Panel3.TabIndex = 76
        '
        'txt_total_adic
        '
        Me.txt_total_adic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_adic.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_total_adic.Enabled = False
        Me.txt_total_adic.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_adic.Location = New System.Drawing.Point(224, 34)
        Me.txt_total_adic.Multiline = True
        Me.txt_total_adic.Name = "txt_total_adic"
        Me.txt_total_adic.Size = New System.Drawing.Size(156, 58)
        Me.txt_total_adic.TabIndex = 9
        Me.txt_total_adic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_total_disc
        '
        Me.txt_total_disc.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_total_disc.Enabled = False
        Me.txt_total_disc.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_disc.Location = New System.Drawing.Point(45, 34)
        Me.txt_total_disc.Multiline = True
        Me.txt_total_disc.Name = "txt_total_disc"
        Me.txt_total_disc.Size = New System.Drawing.Size(156, 58)
        Me.txt_total_disc.TabIndex = 8
        Me.txt_total_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Link_Enfermedad
        '
        Me.Link_Enfermedad.AutoSize = True
        Me.Link_Enfermedad.LinkColor = System.Drawing.Color.Black
        Me.Link_Enfermedad.Location = New System.Drawing.Point(430, 12)
        Me.Link_Enfermedad.Name = "Link_Enfermedad"
        Me.Link_Enfermedad.Size = New System.Drawing.Size(101, 19)
        Me.Link_Enfermedad.TabIndex = 71
        Me.Link_Enfermedad.TabStop = True
        Me.Link_Enfermedad.Text = "ENFERMEDAD"
        '
        'Link_discapacidad
        '
        Me.Link_discapacidad.AutoSize = True
        Me.Link_discapacidad.LinkColor = System.Drawing.Color.Black
        Me.Link_discapacidad.Location = New System.Drawing.Point(71, 12)
        Me.Link_discapacidad.Name = "Link_discapacidad"
        Me.Link_discapacidad.Size = New System.Drawing.Size(106, 19)
        Me.Link_discapacidad.TabIndex = 69
        Me.Link_discapacidad.TabStop = True
        Me.Link_discapacidad.Text = "DISCAPACIDAD"
        '
        'Link_Adiccion
        '
        Me.Link_Adiccion.AutoSize = True
        Me.Link_Adiccion.LinkColor = System.Drawing.Color.Black
        Me.Link_Adiccion.Location = New System.Drawing.Point(262, 12)
        Me.Link_Adiccion.Name = "Link_Adiccion"
        Me.Link_Adiccion.Size = New System.Drawing.Size(75, 19)
        Me.Link_Adiccion.TabIndex = 70
        Me.Link_Adiccion.TabStop = True
        Me.Link_Adiccion.Text = "ADICCION"
        '
        'txt_total_enf
        '
        Me.txt_total_enf.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_total_enf.Enabled = False
        Me.txt_total_enf.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_enf.Location = New System.Drawing.Point(403, 34)
        Me.txt_total_enf.Multiline = True
        Me.txt_total_enf.Name = "txt_total_enf"
        Me.txt_total_enf.Size = New System.Drawing.Size(156, 58)
        Me.txt_total_enf.TabIndex = 10
        Me.txt_total_enf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_plantel
        '
        Me.cb_plantel.DisplayMember = "plantel"
        Me.cb_plantel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plantel.FormattingEnabled = True
        Me.cb_plantel.Location = New System.Drawing.Point(318, 85)
        Me.cb_plantel.Name = "cb_plantel"
        Me.cb_plantel.Size = New System.Drawing.Size(264, 27)
        Me.cb_plantel.TabIndex = 75
        Me.cb_plantel.ValueMember = "plantel"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(1036, 67)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Blue
        Series2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsXValueIndexed = True
        Series2.Legend = "Legend1"
        Series2.Name = "DISCAPACIDAD"
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.Red
        Series3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.Legend = "Legend1"
        Series3.Name = "ADICCION"
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.Green
        Series4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.Legend = "Legend1"
        Series4.Name = "ENFERMEDAD"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(183, 106)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Title1"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TOTAL DE ALUMNOS REGISTRADOS"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.SystemColors.Info
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(40, 55)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(236, 43)
        Me.txt_total.TabIndex = 7
        Me.txt_total.Text = "0"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(314, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PLANTEL"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Btn_sintesis)
        Me.TabPage2.Controls.Add(Me.Btn_Graficar)
        Me.TabPage2.Controls.Add(Me.cb_plantel2)
        Me.TabPage2.Controls.Add(Me.Lbl_registros)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Btn_imprimir)
        Me.TabPage2.Controls.Add(Me.Chk_vertodo)
        Me.TabPage2.Controls.Add(Me.Grid_folio)
        Me.TabPage2.Controls.Add(Me.txt_folio)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Btn_buscar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1255, 591)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSQUEDA"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Btn_sintesis
        '
        Me.Btn_sintesis.Image = CType(resources.GetObject("Btn_sintesis.Image"), System.Drawing.Image)
        Me.Btn_sintesis.Location = New System.Drawing.Point(917, 15)
        Me.Btn_sintesis.Name = "Btn_sintesis"
        Me.Btn_sintesis.Size = New System.Drawing.Size(106, 40)
        Me.Btn_sintesis.TabIndex = 23
        Me.Btn_sintesis.Text = "Semanal"
        Me.Btn_sintesis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_sintesis.UseVisualStyleBackColor = True
        '
        'Btn_Graficar
        '
        Me.Btn_Graficar.Image = CType(resources.GetObject("Btn_Graficar.Image"), System.Drawing.Image)
        Me.Btn_Graficar.Location = New System.Drawing.Point(1029, 15)
        Me.Btn_Graficar.Name = "Btn_Graficar"
        Me.Btn_Graficar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Graficar.TabIndex = 22
        Me.Btn_Graficar.Text = "Graficar"
        Me.Btn_Graficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Graficar.UseVisualStyleBackColor = True
        '
        'cb_plantel2
        '
        Me.cb_plantel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plantel2.FormattingEnabled = True
        Me.cb_plantel2.Location = New System.Drawing.Point(220, 28)
        Me.cb_plantel2.Name = "cb_plantel2"
        Me.cb_plantel2.Size = New System.Drawing.Size(292, 27)
        Me.cb_plantel2.TabIndex = 3
        '
        'Lbl_registros
        '
        Me.Lbl_registros.AutoSize = True
        Me.Lbl_registros.Location = New System.Drawing.Point(587, 36)
        Me.Lbl_registros.Name = "Lbl_registros"
        Me.Lbl_registros.Size = New System.Drawing.Size(118, 19)
        Me.Lbl_registros.TabIndex = 21
        Me.Lbl_registros.Text = "Total 0 Registros"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "PLANTEL"
        '
        'Btn_imprimir
        '
        Me.Btn_imprimir.Image = Global.Psicopedagogico_net.My.Resources.Resources.print
        Me.Btn_imprimir.Location = New System.Drawing.Point(1135, 15)
        Me.Btn_imprimir.Name = "Btn_imprimir"
        Me.Btn_imprimir.Size = New System.Drawing.Size(104, 40)
        Me.Btn_imprimir.TabIndex = 6
        Me.Btn_imprimir.Text = "Imprimir"
        Me.Btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_imprimir.UseVisualStyleBackColor = True
        '
        'Chk_vertodo
        '
        Me.Chk_vertodo.AutoSize = True
        Me.Chk_vertodo.Location = New System.Drawing.Point(568, 7)
        Me.Chk_vertodo.Name = "Chk_vertodo"
        Me.Chk_vertodo.Size = New System.Drawing.Size(185, 23)
        Me.Chk_vertodo.TabIndex = 1
        Me.Chk_vertodo.Text = "VER TODOS LOS FOLIOS"
        Me.Chk_vertodo.UseVisualStyleBackColor = True
        '
        'Grid_folio
        '
        Me.Grid_folio.AllowUserToAddRows = False
        Me.Grid_folio.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_folio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid_folio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid_folio.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Grid_folio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_folio.Location = New System.Drawing.Point(17, 66)
        Me.Grid_folio.Name = "Grid_folio"
        Me.Grid_folio.ReadOnly = True
        Me.Grid_folio.Size = New System.Drawing.Size(1222, 518)
        Me.Grid_folio.TabIndex = 2
        '
        'txt_folio
        '
        Me.txt_folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_folio.Location = New System.Drawing.Point(17, 28)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(194, 27)
        Me.txt_folio.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "FOLIO"
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Image = Global.Psicopedagogico_net.My.Resources.Resources.search1
        Me.Btn_buscar.Location = New System.Drawing.Point(816, 15)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(95, 40)
        Me.Btn_buscar.TabIndex = 4
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_buscar.UseVisualStyleBackColor = True
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
        'DsAlumno
        '
        Me.DsAlumno.DataSetName = "DsAlumno"
        Me.DsAlumno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsAlumnoBindingSource
        '
        Me.DsAlumnoBindingSource.DataSource = Me.DsAlumno
        Me.DsAlumnoBindingSource.Position = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Inicio)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Final)
        Me.GroupBox1.Location = New System.Drawing.Point(386, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 73)
        Me.GroupBox1.TabIndex = 418
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'DateTimePicker_Inicio
        '
        Me.DateTimePicker_Inicio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Inicio.Location = New System.Drawing.Point(56, 12)
        Me.DateTimePicker_Inicio.Name = "DateTimePicker_Inicio"
        Me.DateTimePicker_Inicio.Size = New System.Drawing.Size(113, 27)
        Me.DateTimePicker_Inicio.TabIndex = 407
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 19)
        Me.Label32.TabIndex = 409
        Me.Label32.Text = "Inicio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 19)
        Me.Label16.TabIndex = 410
        Me.Label16.Text = "Final"
        '
        'DateTimePicker_Final
        '
        Me.DateTimePicker_Final.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Final.Location = New System.Drawing.Point(56, 43)
        Me.DateTimePicker_Final.Name = "DateTimePicker_Final"
        Me.DateTimePicker_Final.Size = New System.Drawing.Size(113, 27)
        Me.DateTimePicker_Final.TabIndex = 408
        '
        'Consultas_invitado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1263, 621)
        Me.Controls.Add(Me.TabControl_principal)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consultas_invitado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas_invitado"
        Me.TabControl_principal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Chart_pie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_estadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Grid_folio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl_principal As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Chk_vertodo As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Grid_folio As System.Windows.Forms.DataGridView
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Lbl_registros As System.Windows.Forms.Label
    Friend WithEvents cb_plantel2 As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Chart_pie As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Link_Enfermedad As System.Windows.Forms.LinkLabel
    Friend WithEvents Link_Adiccion As System.Windows.Forms.LinkLabel
    Friend WithEvents Link_discapacidad As System.Windows.Forms.LinkLabel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_total_enf As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_adic As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_disc As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grid_estadistica As System.Windows.Forms.DataGridView
    Friend WithEvents cb_plantel As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Graficar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_sintesis As System.Windows.Forms.Button
    Friend WithEvents DsAlumno As DsAlumno
    Friend WithEvents DsAlumnoBindingSource As BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Final As System.Windows.Forms.DateTimePicker
End Class
