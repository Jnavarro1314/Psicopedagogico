<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grupos))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GB_Tema = New System.Windows.Forms.GroupBox()
        Me.txt_tema = New System.Windows.Forms.TextBox()
        Me.cb_nivel = New System.Windows.Forms.ComboBox()
        Me.CB_Sedes = New System.Windows.Forms.ComboBox()

        Me.GB_Plantel = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_especialidad = New System.Windows.Forms.TextBox()
        Me.txt_Estado = New System.Windows.Forms.TextBox()
        Me.txt_ciudad = New System.Windows.Forms.TextBox()
        Me.GB_Ponente = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_institucion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Experiencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ponente_esp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ponente = New System.Windows.Forms.TextBox()
        Me.GB_Grafica = New System.Windows.Forms.GroupBox()
        Me.NumBeneficiados = New System.Windows.Forms.NumericUpDown()
        Me.NumPlantel = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Graficar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GB_Resp = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LP2 = New System.Windows.Forms.Label()
        Me.LR1 = New System.Windows.Forms.Label()
        Me.txt_Puesto2 = New System.Windows.Forms.TextBox()
        Me.txt_Puesto1 = New System.Windows.Forms.TextBox()
        Me.txt_Responsable2 = New System.Windows.Forms.TextBox()
        Me.txt_Responsable1 = New System.Windows.Forms.TextBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.GB_Observaciones = New System.Windows.Forms.GroupBox()
        Me.Piker_fecha = New System.Windows.Forms.DateTimePicker()
        Me.GB_Fecha = New System.Windows.Forms.GroupBox()
        Me.Piker_hora = New System.Windows.Forms.DateTimePicker()
        Me.Btn_cancelar = New System.Windows.Forms.Button()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()

        Me.ToolStrip_Titulo.SuspendLayout()
        Me.GB_Tema.SuspendLayout()

        Me.GB_Plantel.SuspendLayout()
        Me.GB_Ponente.SuspendLayout()
        Me.GB_Grafica.SuspendLayout()
        CType(Me.NumBeneficiados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPlantel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Resp.SuspendLayout()
        Me.GB_Observaciones.SuspendLayout()
        Me.GB_Fecha.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip_Titulo
        '
        Me.ToolStrip_Titulo.AutoSize = False
        Me.ToolStrip_Titulo.BackColor = System.Drawing.Color.DarkMagenta
        Me.ToolStrip_Titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_Titulo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip_Titulo.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_Titulo.Name = "ToolStrip_Titulo"
        Me.ToolStrip_Titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(987, 44)
        Me.ToolStrip_Titulo.TabIndex = 15
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(168, 41)
        Me.ToolStripLabel1.Text = "Atención a Grupos"
        '
        'GB_Tema
        '
        Me.GB_Tema.Controls.Add(Me.txt_tema)
        Me.GB_Tema.Location = New System.Drawing.Point(12, 47)
        Me.GB_Tema.Name = "GB_Tema"
        Me.GB_Tema.Size = New System.Drawing.Size(707, 87)
        Me.GB_Tema.TabIndex = 17
        Me.GB_Tema.TabStop = False
        Me.GB_Tema.Text = "TEMA"
        '
        'txt_tema
        '
        Me.txt_tema.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tema.Location = New System.Drawing.Point(7, 35)
        Me.txt_tema.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tema.MaxLength = 500
        Me.txt_tema.Multiline = True
        Me.txt_tema.Name = "txt_tema"
        Me.txt_tema.Size = New System.Drawing.Size(693, 44)
        Me.txt_tema.TabIndex = 1
        Me.txt_tema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_nivel
        '
        Me.cb_nivel.DropDownHeight = 120
        Me.cb_nivel.FormattingEnabled = True
        Me.cb_nivel.IntegralHeight = False
        Me.cb_nivel.Items.AddRange(New Object() {"PREESCOLAR", "PRIMARIA", "SECUNDARIA", "PREPARATORIA", "UNIVERSIDAD", "MAESTRIA", "DOCTORADO", "COORDINADORES", "DOCENTES", "ADMINISTRATIVOS", "PADRES DE FAMILIA", "OTRO", "S/I"})
        Me.cb_nivel.Location = New System.Drawing.Point(12, 154)
        Me.cb_nivel.MaxLength = 99
        Me.cb_nivel.Name = "cb_nivel"
        Me.cb_nivel.Size = New System.Drawing.Size(237, 27)
        Me.cb_nivel.TabIndex = 5
        '
        'CB_Sedes
        '
        Me.CB_Sedes.DropDownHeight = 120
        Me.CB_Sedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Sedes.FormattingEnabled = True
        Me.CB_Sedes.IntegralHeight = False
        Me.CB_Sedes.ItemHeight = 19
        Me.CB_Sedes.Location = New System.Drawing.Point(12, 26)
        Me.CB_Sedes.Name = "CB_Sedes"
        Me.CB_Sedes.Size = New System.Drawing.Size(237, 27)
        Me.CB_Sedes.TabIndex = 2
        Me.CB_Sedes.ValueMember = "Sede"
        '

        '
        'GB_Plantel
        '
        Me.GB_Plantel.Controls.Add(Me.GroupBox2)
        Me.GB_Plantel.Controls.Add(Me.Label1)
        Me.GB_Plantel.Controls.Add(Me.Label13)
        Me.GB_Plantel.Controls.Add(Me.txt_especialidad)
        Me.GB_Plantel.Controls.Add(Me.txt_Estado)
        Me.GB_Plantel.Controls.Add(Me.txt_ciudad)
        Me.GB_Plantel.Controls.Add(Me.cb_nivel)
        Me.GB_Plantel.Controls.Add(Me.CB_Sedes)
        Me.GB_Plantel.Location = New System.Drawing.Point(12, 143)
        Me.GB_Plantel.Name = "GB_Plantel"
        Me.GB_Plantel.Size = New System.Drawing.Size(262, 245)
        Me.GB_Plantel.TabIndex = 20
        Me.GB_Plantel.TabStop = False
        Me.GB_Plantel.Text = "PLANTEL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(10, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 72)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "GRUPO/ESPECIALIDAD"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "NIVEL EDUCATIVO"
        '
        'txt_especialidad
        '
        Me.txt_especialidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_especialidad.Location = New System.Drawing.Point(11, 208)
        Me.txt_especialidad.MaxLength = 99
        Me.txt_especialidad.Name = "txt_especialidad"
        Me.txt_especialidad.Size = New System.Drawing.Size(237, 27)
        Me.txt_especialidad.TabIndex = 6
        '
        'txt_Estado
        '
        Me.txt_Estado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Estado.Enabled = False
        Me.txt_Estado.Location = New System.Drawing.Point(12, 92)
        Me.txt_Estado.MaxLength = 99
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.Size = New System.Drawing.Size(237, 27)
        Me.txt_Estado.TabIndex = 4
        '
        'txt_ciudad
        '
        Me.txt_ciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ciudad.Enabled = False
        Me.txt_ciudad.Location = New System.Drawing.Point(12, 59)
        Me.txt_ciudad.MaxLength = 99
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(237, 27)
        Me.txt_ciudad.TabIndex = 3
        '
        'GB_Ponente
        '
        Me.GB_Ponente.Controls.Add(Me.Label7)
        Me.GB_Ponente.Controls.Add(Me.Label6)
        Me.GB_Ponente.Controls.Add(Me.txt_telefono)
        Me.GB_Ponente.Controls.Add(Me.txt_institucion)
        Me.GB_Ponente.Controls.Add(Me.Label4)
        Me.GB_Ponente.Controls.Add(Me.txt_Experiencia)
        Me.GB_Ponente.Controls.Add(Me.Label5)
        Me.GB_Ponente.Controls.Add(Me.txt_ponente_esp)
        Me.GB_Ponente.Controls.Add(Me.Label3)
        Me.GB_Ponente.Controls.Add(Me.txt_titulo)
        Me.GB_Ponente.Controls.Add(Me.Label2)
        Me.GB_Ponente.Controls.Add(Me.txt_ponente)
        Me.GB_Ponente.Location = New System.Drawing.Point(289, 143)
        Me.GB_Ponente.Name = "GB_Ponente"
        Me.GB_Ponente.Size = New System.Drawing.Size(430, 245)
        Me.GB_Ponente.TabIndex = 22
        Me.GB_Ponente.TabStop = False
        Me.GB_Ponente.Text = "PONENTE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "INSTITUCION COLABORATIVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "TELEFONO"
        '
        'txt_telefono
        '
        Me.txt_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_telefono.Location = New System.Drawing.Point(113, 124)
        Me.txt_telefono.MaxLength = 99
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(304, 27)
        Me.txt_telefono.TabIndex = 11
        '
        'txt_institucion
        '
        Me.txt_institucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_institucion.Location = New System.Drawing.Point(10, 208)
        Me.txt_institucion.MaxLength = 99
        Me.txt_institucion.Name = "txt_institucion"
        Me.txt_institucion.Size = New System.Drawing.Size(407, 27)
        Me.txt_institucion.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "EXPERIENCIA"
        '
        'txt_Experiencia
        '
        Me.txt_Experiencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Experiencia.Location = New System.Drawing.Point(113, 157)
        Me.txt_Experiencia.MaxLength = 99
        Me.txt_Experiencia.Name = "txt_Experiencia"
        Me.txt_Experiencia.Size = New System.Drawing.Size(304, 27)
        Me.txt_Experiencia.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "ESPECIALIDAD"
        '
        'txt_ponente_esp
        '
        Me.txt_ponente_esp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ponente_esp.Location = New System.Drawing.Point(113, 91)
        Me.txt_ponente_esp.MaxLength = 99
        Me.txt_ponente_esp.Name = "txt_ponente_esp"
        Me.txt_ponente_esp.Size = New System.Drawing.Size(304, 27)
        Me.txt_ponente_esp.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "TITULO"
        '
        'txt_titulo
        '
        Me.txt_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_titulo.Location = New System.Drawing.Point(113, 59)
        Me.txt_titulo.MaxLength = 99
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(304, 27)
        Me.txt_titulo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "NOMBRE"
        '
        'txt_ponente
        '
        Me.txt_ponente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ponente.Location = New System.Drawing.Point(113, 26)
        Me.txt_ponente.MaxLength = 99
        Me.txt_ponente.Name = "txt_ponente"
        Me.txt_ponente.Size = New System.Drawing.Size(304, 27)
        Me.txt_ponente.TabIndex = 7
        '
        'GB_Grafica
        '
        Me.GB_Grafica.Controls.Add(Me.NumBeneficiados)
        Me.GB_Grafica.Controls.Add(Me.NumPlantel)
        Me.GB_Grafica.Controls.Add(Me.Btn_Graficar)
        Me.GB_Grafica.Controls.Add(Me.Label10)
        Me.GB_Grafica.Controls.Add(Me.Chart1)
        Me.GB_Grafica.Controls.Add(Me.Label8)
        Me.GB_Grafica.Location = New System.Drawing.Point(732, 143)
        Me.GB_Grafica.Name = "GB_Grafica"
        Me.GB_Grafica.Size = New System.Drawing.Size(243, 245)
        Me.GB_Grafica.TabIndex = 23
        Me.GB_Grafica.TabStop = False
        Me.GB_Grafica.Text = "TOTAL DE ALUMNOS"
        '
        'NumBeneficiados
        '
        Me.NumBeneficiados.Location = New System.Drawing.Point(150, 52)
        Me.NumBeneficiados.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumBeneficiados.Name = "NumBeneficiados"
        Me.NumBeneficiados.Size = New System.Drawing.Size(73, 27)
        Me.NumBeneficiados.TabIndex = 14
        '
        'NumPlantel
        '
        Me.NumPlantel.Location = New System.Drawing.Point(24, 52)
        Me.NumPlantel.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumPlantel.Name = "NumPlantel"
        Me.NumPlantel.Size = New System.Drawing.Size(73, 27)
        Me.NumPlantel.TabIndex = 13
        '
        'Btn_Graficar
        '
        Me.Btn_Graficar.Image = CType(resources.GetObject("Btn_Graficar.Image"), System.Drawing.Image)
        Me.Btn_Graficar.Location = New System.Drawing.Point(199, 208)
        Me.Btn_Graficar.Name = "Btn_Graficar"
        Me.Btn_Graficar.Size = New System.Drawing.Size(39, 32)
        Me.Btn_Graficar.TabIndex = 79
        Me.Btn_Graficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Graficar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "POR PLANTEL"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 105)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Green}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(231, 134)
        Me.Chart1.TabIndex = 31
        Me.Chart1.Text = "Chart1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(133, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "BENEFICIADOS"
        '
        'GB_Resp
        '
        Me.GB_Resp.Controls.Add(Me.Label11)
        Me.GB_Resp.Controls.Add(Me.Label9)
        Me.GB_Resp.Controls.Add(Me.LP2)
        Me.GB_Resp.Controls.Add(Me.LR1)
        Me.GB_Resp.Controls.Add(Me.txt_Puesto2)
        Me.GB_Resp.Controls.Add(Me.txt_Puesto1)
        Me.GB_Resp.Controls.Add(Me.txt_Responsable2)
        Me.GB_Resp.Controls.Add(Me.txt_Responsable1)
        Me.GB_Resp.Location = New System.Drawing.Point(12, 394)
        Me.GB_Resp.Name = "GB_Resp"
        Me.GB_Resp.Size = New System.Drawing.Size(707, 100)
        Me.GB_Resp.TabIndex = 24
        Me.GB_Resp.TabStop = False
        Me.GB_Resp.Text = "RESPONSABLES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 19)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "NOMBRE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(397, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 19)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "PUESTO"
        '
        'LP2
        '
        Me.LP2.AutoSize = True
        Me.LP2.ForeColor = System.Drawing.Color.Black
        Me.LP2.Location = New System.Drawing.Point(397, 31)
        Me.LP2.Name = "LP2"
        Me.LP2.Size = New System.Drawing.Size(61, 19)
        Me.LP2.TabIndex = 40
        Me.LP2.Text = "PUESTO"
        '
        'LR1
        '
        Me.LR1.AutoSize = True
        Me.LR1.ForeColor = System.Drawing.Color.Black
        Me.LR1.Location = New System.Drawing.Point(3, 31)
        Me.LR1.Name = "LR1"
        Me.LR1.Size = New System.Drawing.Size(69, 19)
        Me.LR1.TabIndex = 35
        Me.LR1.Text = "NOMBRE"
        '
        'txt_Puesto2
        '
        Me.txt_Puesto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Puesto2.Location = New System.Drawing.Point(459, 61)
        Me.txt_Puesto2.MaxLength = 99
        Me.txt_Puesto2.Name = "txt_Puesto2"
        Me.txt_Puesto2.Size = New System.Drawing.Size(238, 27)
        Me.txt_Puesto2.TabIndex = 18
        '
        'txt_Puesto1
        '
        Me.txt_Puesto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Puesto1.Location = New System.Drawing.Point(459, 28)
        Me.txt_Puesto1.MaxLength = 99
        Me.txt_Puesto1.Name = "txt_Puesto1"
        Me.txt_Puesto1.Size = New System.Drawing.Size(238, 27)
        Me.txt_Puesto1.TabIndex = 16
        '
        'txt_Responsable2
        '
        Me.txt_Responsable2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Responsable2.Location = New System.Drawing.Point(73, 61)
        Me.txt_Responsable2.MaxLength = 99
        Me.txt_Responsable2.Name = "txt_Responsable2"
        Me.txt_Responsable2.Size = New System.Drawing.Size(318, 27)
        Me.txt_Responsable2.TabIndex = 17
        '
        'txt_Responsable1
        '
        Me.txt_Responsable1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Responsable1.Location = New System.Drawing.Point(73, 28)
        Me.txt_Responsable1.MaxLength = 99
        Me.txt_Responsable1.Name = "txt_Responsable1"
        Me.txt_Responsable1.Size = New System.Drawing.Size(318, 27)
        Me.txt_Responsable1.TabIndex = 15
        '
        'txt_observaciones
        '
        Me.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_observaciones.Location = New System.Drawing.Point(7, 18)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_observaciones.MaxLength = 5000
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(690, 90)
        Me.txt_observaciones.TabIndex = 21
        '
        'GB_Observaciones
        '
        Me.GB_Observaciones.Controls.Add(Me.txt_observaciones)
        Me.GB_Observaciones.Location = New System.Drawing.Point(12, 500)
        Me.GB_Observaciones.Name = "GB_Observaciones"
        Me.GB_Observaciones.Size = New System.Drawing.Size(707, 113)
        Me.GB_Observaciones.TabIndex = 69
        Me.GB_Observaciones.TabStop = False
        Me.GB_Observaciones.Text = "OBSERVACIONES"
        '
        'Piker_fecha
        '
        Me.Piker_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Piker_fecha.Location = New System.Drawing.Point(15, 26)
        Me.Piker_fecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.Piker_fecha.Name = "Piker_fecha"
        Me.Piker_fecha.Size = New System.Drawing.Size(211, 27)
        Me.Piker_fecha.TabIndex = 19
        '
        'GB_Fecha
        '
        Me.GB_Fecha.Controls.Add(Me.Piker_hora)
        Me.GB_Fecha.Controls.Add(Me.Piker_fecha)
        Me.GB_Fecha.Location = New System.Drawing.Point(732, 394)
        Me.GB_Fecha.Name = "GB_Fecha"
        Me.GB_Fecha.Size = New System.Drawing.Size(243, 100)
        Me.GB_Fecha.TabIndex = 78
        Me.GB_Fecha.TabStop = False
        Me.GB_Fecha.Text = "FECHA Y HORA CANALIZACION"
        '
        'Piker_hora
        '
        Me.Piker_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Piker_hora.Location = New System.Drawing.Point(15, 59)
        Me.Piker_hora.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.Piker_hora.Name = "Piker_hora"
        Me.Piker_hora.Size = New System.Drawing.Size(211, 27)
        Me.Piker_hora.TabIndex = 20
        '
        'Btn_cancelar
        '
        Me.Btn_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancelar.Image = Global.Psicopedagogico_net.My.Resources.Resources.cancel
        Me.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cancelar.Location = New System.Drawing.Point(753, 564)
        Me.Btn_cancelar.Name = "Btn_cancelar"
        Me.Btn_cancelar.Size = New System.Drawing.Size(101, 40)
        Me.Btn_cancelar.TabIndex = 23
        Me.Btn_cancelar.Text = "Cancelar"
        Me.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cancelar.UseVisualStyleBackColor = True
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Image = Global.Psicopedagogico_net.My.Resources.Resources.search1
        Me.Btn_buscar.Location = New System.Drawing.Point(754, 518)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_buscar.TabIndex = 24
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Image = Global.Psicopedagogico_net.My.Resources.Resources.print
        Me.Btn_Imprimir.Location = New System.Drawing.Point(856, 518)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(104, 40)
        Me.Btn_Imprimir.TabIndex = 25
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = Global.Psicopedagogico_net.My.Resources.Resources.save
        Me.Btn_Guardar.Location = New System.Drawing.Point(856, 564)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(104, 40)
        Me.Btn_Guardar.TabIndex = 22
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Psicopedagogico_net.My.Resources.Resources.logo_psicop
        Me.PictureBox1.Location = New System.Drawing.Point(732, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 624)
        Me.Controls.Add(Me.Btn_cancelar)
        Me.Controls.Add(Me.Btn_buscar)
        Me.Controls.Add(Me.GB_Fecha)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.GB_Observaciones)
        Me.Controls.Add(Me.GB_Resp)
        Me.Controls.Add(Me.GB_Grafica)
        Me.Controls.Add(Me.GB_Ponente)
        Me.Controls.Add(Me.GB_Plantel)
        Me.Controls.Add(Me.GB_Tema)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Grupos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        Me.GB_Tema.ResumeLayout(False)
        Me.GB_Tema.PerformLayout()

        Me.GB_Plantel.ResumeLayout(False)
        Me.GB_Plantel.PerformLayout()
        Me.GB_Ponente.ResumeLayout(False)
        Me.GB_Ponente.PerformLayout()
        Me.GB_Grafica.ResumeLayout(False)
        Me.GB_Grafica.PerformLayout()
        CType(Me.NumBeneficiados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPlantel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Resp.ResumeLayout(False)
        Me.GB_Resp.PerformLayout()
        Me.GB_Observaciones.ResumeLayout(False)
        Me.GB_Observaciones.PerformLayout()
        Me.GB_Fecha.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GB_Tema As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tema As System.Windows.Forms.TextBox
    Friend WithEvents cb_nivel As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Sedes As System.Windows.Forms.ComboBox
    Friend WithEvents GB_Plantel As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents txt_especialidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GB_Ponente As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_institucion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Experiencia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_ponente_esp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ponente As System.Windows.Forms.TextBox
    Friend WithEvents GB_Grafica As System.Windows.Forms.GroupBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Resp As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Responsable1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Responsable2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Puesto2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Puesto1 As System.Windows.Forms.TextBox
    Friend WithEvents LP2 As System.Windows.Forms.Label
    Friend WithEvents LR1 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents GB_Observaciones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Piker_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GB_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents Piker_hora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Graficar As System.Windows.Forms.Button
    Friend WithEvents NumBeneficiados As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumPlantel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
