<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tamizaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tamizaje))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.CBPlantel = New System.Windows.Forms.ComboBox()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.PanelResultados = New System.Windows.Forms.Panel()
        Me.ComboSexo = New System.Windows.Forms.ComboBox()
        Me.CBViolencia = New System.Windows.Forms.ComboBox()
        Me.CBDepresion = New System.Windows.Forms.ComboBox()
        Me.CBAnsiedad = New System.Windows.Forms.ComboBox()
        Me.CBConsumo = New System.Windows.Forms.ComboBox()
        Me.CBSuicida = New System.Windows.Forms.ComboBox()
        Me.NumEdad = New System.Windows.Forms.NumericUpDown()
        Me.CBConductas = New System.Windows.Forms.ComboBox()
        Me.CBSustancias = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.BtnGraficar = New System.Windows.Forms.Button()
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.GridTamizaje = New System.Windows.Forms.DataGridView()
        Me.ALUMNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RIESGO_SUICIDA = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DEPRESION = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ANSIEDAD = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VIOLENCIA = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NIVEL_SUSTANCIAS = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SUSTANCIAS = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CONDUCTAS = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QUITAR = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Menu_Copiar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_Pegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        Me.PanelResultados.SuspendLayout()
        CType(Me.NumEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_Titulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridTamizaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_Copiar.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GBDatos)
        Me.Panel1.Controls.Add(Me.PanelResultados)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.TextBox18)
        Me.Panel1.Controls.Add(Me.BtnReporte)
        Me.Panel1.Controls.Add(Me.BtnGraficar)
        Me.Panel1.Controls.Add(Me.ToolStrip_Titulo)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox19)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox11)
        Me.Panel1.Controls.Add(Me.GridTamizaje)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1377, 677)
        Me.Panel1.TabIndex = 67
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.Label11)
        Me.GBDatos.Controls.Add(Me.Label12)
        Me.GBDatos.Controls.Add(Me.Label4)
        Me.GBDatos.Controls.Add(Me.Label10)
        Me.GBDatos.Controls.Add(Me.Label3)
        Me.GBDatos.Controls.Add(Me.Label2)
        Me.GBDatos.Controls.Add(Me.PickerFecha)
        Me.GBDatos.Controls.Add(Me.txtLugar)
        Me.GBDatos.Controls.Add(Me.txtGrupo)
        Me.GBDatos.Controls.Add(Me.txtTurno)
        Me.GBDatos.Controls.Add(Me.CBPlantel)
        Me.GBDatos.Controls.Add(Me.txtAlumno)
        Me.GBDatos.Location = New System.Drawing.Point(33, 161)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(1289, 94)
        Me.GBDatos.TabIndex = 94
        Me.GBDatos.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(874, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 19)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "LUGAR:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(874, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 19)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "FECHA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(540, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "TURNO:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(540, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 19)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "GRUPO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "ALUMNO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "PLANTEL:"
        '
        'PickerFecha
        '
        Me.PickerFecha.Location = New System.Drawing.Point(943, 59)
        Me.PickerFecha.Name = "PickerFecha"
        Me.PickerFecha.Size = New System.Drawing.Size(316, 27)
        Me.PickerFecha.TabIndex = 7
        '
        'txtLugar
        '
        Me.txtLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugar.Location = New System.Drawing.Point(943, 26)
        Me.txtLugar.MaxLength = 500
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(316, 27)
        Me.txtLugar.TabIndex = 6
        '
        'txtGrupo
        '
        Me.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupo.Location = New System.Drawing.Point(617, 59)
        Me.txtGrupo.MaxLength = 100
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(213, 27)
        Me.txtGrupo.TabIndex = 5
        '
        'txtTurno
        '
        Me.txtTurno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTurno.Location = New System.Drawing.Point(617, 26)
        Me.txtTurno.MaxLength = 100
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(213, 27)
        Me.txtTurno.TabIndex = 4
        '
        'CBPlantel
        '
        Me.CBPlantel.DropDownHeight = 160
        Me.CBPlantel.FormattingEnabled = True
        Me.CBPlantel.IntegralHeight = False
        Me.CBPlantel.Location = New System.Drawing.Point(111, 59)
        Me.CBPlantel.Name = "CBPlantel"
        Me.CBPlantel.Size = New System.Drawing.Size(393, 27)
        Me.CBPlantel.TabIndex = 3
        '
        'txtAlumno
        '
        Me.txtAlumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlumno.Location = New System.Drawing.Point(111, 26)
        Me.txtAlumno.MaxLength = 500
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(393, 27)
        Me.txtAlumno.TabIndex = 2
        '
        'PanelResultados
        '
        Me.PanelResultados.Controls.Add(Me.ComboSexo)
        Me.PanelResultados.Controls.Add(Me.CBViolencia)
        Me.PanelResultados.Controls.Add(Me.CBDepresion)
        Me.PanelResultados.Controls.Add(Me.CBAnsiedad)
        Me.PanelResultados.Controls.Add(Me.CBConsumo)
        Me.PanelResultados.Controls.Add(Me.CBSuicida)
        Me.PanelResultados.Controls.Add(Me.NumEdad)
        Me.PanelResultados.Controls.Add(Me.CBConductas)
        Me.PanelResultados.Controls.Add(Me.CBSustancias)
        Me.PanelResultados.Location = New System.Drawing.Point(29, 330)
        Me.PanelResultados.Name = "PanelResultados"
        Me.PanelResultados.Size = New System.Drawing.Size(1045, 29)
        Me.PanelResultados.TabIndex = 7
        '
        'ComboSexo
        '
        Me.ComboSexo.FormattingEnabled = True
        Me.ComboSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.ComboSexo.Location = New System.Drawing.Point(64, 0)
        Me.ComboSexo.Name = "ComboSexo"
        Me.ComboSexo.Size = New System.Drawing.Size(117, 27)
        Me.ComboSexo.TabIndex = 9
        '
        'CBViolencia
        '
        Me.CBViolencia.FormattingEnabled = True
        Me.CBViolencia.Items.AddRange(New Object() {"PSICOLOGICA", "FISICA", "NEGLIGENCIA", "SEXUAL", "NEGATIVO"})
        Me.CBViolencia.Location = New System.Drawing.Point(518, 0)
        Me.CBViolencia.Name = "CBViolencia"
        Me.CBViolencia.Size = New System.Drawing.Size(117, 27)
        Me.CBViolencia.TabIndex = 13
        '
        'CBDepresion
        '
        Me.CBDepresion.FormattingEnabled = True
        Me.CBDepresion.Items.AddRange(New Object() {"LEVE", "MODERADO", "GRAVE", "NEGATIVO"})
        Me.CBDepresion.Location = New System.Drawing.Point(300, 0)
        Me.CBDepresion.Name = "CBDepresion"
        Me.CBDepresion.Size = New System.Drawing.Size(117, 27)
        Me.CBDepresion.TabIndex = 11
        '
        'CBAnsiedad
        '
        Me.CBAnsiedad.FormattingEnabled = True
        Me.CBAnsiedad.Items.AddRange(New Object() {"POSITIVO", "NEGATIVO"})
        Me.CBAnsiedad.Location = New System.Drawing.Point(416, 0)
        Me.CBAnsiedad.Name = "CBAnsiedad"
        Me.CBAnsiedad.Size = New System.Drawing.Size(104, 27)
        Me.CBAnsiedad.TabIndex = 12
        '
        'CBConsumo
        '
        Me.CBConsumo.FormattingEnabled = True
        Me.CBConsumo.Items.AddRange(New Object() {"LEVE", "MODERADO", "GRAVE", "NEGATIVO"})
        Me.CBConsumo.Location = New System.Drawing.Point(634, 0)
        Me.CBConsumo.Name = "CBConsumo"
        Me.CBConsumo.Size = New System.Drawing.Size(107, 27)
        Me.CBConsumo.TabIndex = 14
        '
        'CBSuicida
        '
        Me.CBSuicida.FormattingEnabled = True
        Me.CBSuicida.Items.AddRange(New Object() {"POSITIVO", "NEGATIVO"})
        Me.CBSuicida.Location = New System.Drawing.Point(180, 0)
        Me.CBSuicida.Name = "CBSuicida"
        Me.CBSuicida.Size = New System.Drawing.Size(121, 27)
        Me.CBSuicida.TabIndex = 10
        '
        'NumEdad
        '
        Me.NumEdad.Location = New System.Drawing.Point(4, 0)
        Me.NumEdad.Maximum = New Decimal(New Integer() {29, 0, 0, 0})
        Me.NumEdad.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumEdad.Name = "NumEdad"
        Me.NumEdad.Size = New System.Drawing.Size(62, 27)
        Me.NumEdad.TabIndex = 8
        Me.NumEdad.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'CBConductas
        '
        Me.CBConductas.FormattingEnabled = True
        Me.CBConductas.Items.AddRange(New Object() {"POSITIVO", "NEGATIVO"})
        Me.CBConductas.Location = New System.Drawing.Point(914, 0)
        Me.CBConductas.Name = "CBConductas"
        Me.CBConductas.Size = New System.Drawing.Size(126, 27)
        Me.CBConductas.TabIndex = 16
        '
        'CBSustancias
        '
        Me.CBSustancias.FormattingEnabled = True
        Me.CBSustancias.Items.AddRange(New Object() {"TABACO", "BEBIDAS ALCOHOLICAS", "CANNABIS", "COCAINA", "ESTIMULANTES DE TIPO ANFETAMINA", "INHALABLES", "SEDANTES O PASTILLAS PARA DORMIR", "ALUCINOGENOS", "OPIACEOS", "OTRO (ESPECIFIQUE)", "NINGUNO"})
        Me.CBSustancias.Location = New System.Drawing.Point(740, 0)
        Me.CBSustancias.Name = "CBSustancias"
        Me.CBSustancias.Size = New System.Drawing.Size(175, 27)
        Me.CBSustancias.TabIndex = 15
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(1075, 326)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(127, 36)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(93, 288)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(117, 46)
        Me.TextBox18.TabIndex = 87
        Me.TextBox18.Text = "SEXO"
        '
        'BtnReporte
        '
        Me.BtnReporte.Image = CType(resources.GetObject("BtnReporte.Image"), System.Drawing.Image)
        Me.BtnReporte.Location = New System.Drawing.Point(1204, 326)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(118, 36)
        Me.BtnReporte.TabIndex = 20
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'BtnGraficar
        '
        Me.BtnGraficar.Image = CType(resources.GetObject("BtnGraficar.Image"), System.Drawing.Image)
        Me.BtnGraficar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGraficar.Location = New System.Drawing.Point(1204, 288)
        Me.BtnGraficar.Name = "BtnGraficar"
        Me.BtnGraficar.Size = New System.Drawing.Size(118, 37)
        Me.BtnGraficar.TabIndex = 19
        Me.BtnGraficar.Text = "Graficar"
        Me.BtnGraficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGraficar.UseVisualStyleBackColor = True
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(1373, 44)
        Me.ToolStrip_Titulo.TabIndex = 90
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(518, 41)
        Me.ToolStripLabel1.Text = "Lista de Resultados de Tamizaje de Riesgo Psicosocial UCEM" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(209, 288)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(121, 46)
        Me.TextBox5.TabIndex = 88
        Me.TextBox5.Text = "RIESGO SUICIDA"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Psicopedagogico_net.My.Resources.Resources.vidas
        Me.PictureBox2.Location = New System.Drawing.Point(33, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(127, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 82
        Me.PictureBox2.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(329, 288)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(117, 46)
        Me.TextBox6.TabIndex = 89
        Me.TextBox6.Text = "DEPRESION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(599, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "RESULTADOS"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(33, 288)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(62, 46)
        Me.TextBox19.TabIndex = 86
        Me.TextBox19.Text = "EDAD"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Psicopedagogico_net.My.Resources.Resources.logo_psicop
        Me.PictureBox1.Location = New System.Drawing.Point(1095, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(541, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(251, 19)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Departamento Psicopedaógico UCEM" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(444, 288)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(104, 46)
        Me.TextBox7.TabIndex = 90
        Me.TextBox7.Text = "ANSIEDAD"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(547, 288)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(117, 46)
        Me.TextBox12.TabIndex = 91
        Me.TextBox12.Text = "VIOLENCIA EN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADOLESCENTES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(405, 19)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Lista de Resultados de Tamizaje de Riesgo Psicosocial UCEM" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(572, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 19)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "LINEA DE SALUD MENTAL" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(369, 19)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Proyecto Especifico de Salud Integral ""SI SALUD UCEM"" " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(943, 288)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(126, 46)
        Me.TextBox10.TabIndex = 93
        Me.TextBox10.Text = "CONDUNCTAS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALIM. DE RIESGO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(572, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 19)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "SALUD ESCOLAR UCEM" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(663, 288)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(281, 46)
        Me.TextBox11.TabIndex = 92
        Me.TextBox11.Text = "CONSUMO DE SUSTANCIAS"
        '
        'GridTamizaje
        '
        Me.GridTamizaje.AllowUserToAddRows = False
        Me.GridTamizaje.AllowUserToDeleteRows = False
        Me.GridTamizaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridTamizaje.BackgroundColor = System.Drawing.Color.Lavender
        Me.GridTamizaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTamizaje.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ALUMNO, Me.EDAD, Me.SEXO, Me.RIESGO_SUICIDA, Me.DEPRESION, Me.ANSIEDAD, Me.VIOLENCIA, Me.NIVEL_SUSTANCIAS, Me.SUSTANCIAS, Me.CONDUCTAS, Me.QUITAR})
        Me.GridTamizaje.ContextMenuStrip = Me.Menu_Copiar
        Me.GridTamizaje.Location = New System.Drawing.Point(0, 371)
        Me.GridTamizaje.Name = "GridTamizaje"
        Me.GridTamizaje.Size = New System.Drawing.Size(1360, 298)
        Me.GridTamizaje.TabIndex = 21
        '
        'ALUMNO
        '
        Me.ALUMNO.FillWeight = 1.243278!
        Me.ALUMNO.HeaderText = "ALUMNO"
        Me.ALUMNO.MinimumWidth = 150
        Me.ALUMNO.Name = "ALUMNO"
        '
        'EDAD
        '
        Me.EDAD.FillWeight = 0.7391175!
        Me.EDAD.HeaderText = "EDAD"
        Me.EDAD.MinimumWidth = 100
        Me.EDAD.Name = "EDAD"
        '
        'SEXO
        '
        Me.SEXO.FillWeight = 0.439207!
        Me.SEXO.HeaderText = "SEXO"
        Me.SEXO.MinimumWidth = 100
        Me.SEXO.Name = "SEXO"
        '
        'RIESGO_SUICIDA
        '
        Me.RIESGO_SUICIDA.FillWeight = 0.2609276!
        Me.RIESGO_SUICIDA.HeaderText = "RIESGO SUICIDA"
        Me.RIESGO_SUICIDA.Items.AddRange(New Object() {"POSITIVO", "NEGATIVO"})
        Me.RIESGO_SUICIDA.MinimumWidth = 100
        Me.RIESGO_SUICIDA.Name = "RIESGO_SUICIDA"
        Me.RIESGO_SUICIDA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RIESGO_SUICIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DEPRESION
        '
        Me.DEPRESION.FillWeight = 0.1549932!
        Me.DEPRESION.HeaderText = "DEPRESION"
        Me.DEPRESION.Items.AddRange(New Object() {"LEVE", "MODERADO", "GRAVE", "NEGATIVO"})
        Me.DEPRESION.MinimumWidth = 100
        Me.DEPRESION.Name = "DEPRESION"
        Me.DEPRESION.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPRESION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ANSIEDAD
        '
        Me.ANSIEDAD.FillWeight = 0.09206037!
        Me.ANSIEDAD.HeaderText = "ANSIEDAD"
        Me.ANSIEDAD.Items.AddRange(New Object() {"POSITIVO", "NEGATIVO"})
        Me.ANSIEDAD.MinimumWidth = 100
        Me.ANSIEDAD.Name = "ANSIEDAD"
        Me.ANSIEDAD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ANSIEDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'VIOLENCIA
        '
        Me.VIOLENCIA.FillWeight = 149.7844!
        Me.VIOLENCIA.HeaderText = "VIOLENCIA EN ADOLESCENTES"
        Me.VIOLENCIA.Items.AddRange(New Object() {"PSICOLOGICA", "FISICA", "NEGLIGENCIA", "SEXUAL", "NEGATIVO"})
        Me.VIOLENCIA.MinimumWidth = 150
        Me.VIOLENCIA.Name = "VIOLENCIA"
        Me.VIOLENCIA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VIOLENCIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'NIVEL_SUSTANCIAS
        '
        Me.NIVEL_SUSTANCIAS.HeaderText = "NIVEL SUSTANCIAS"
        Me.NIVEL_SUSTANCIAS.Items.AddRange(New Object() {"LEVE", "MODERADO", "GRAVE", "NEGATIVO"})
        Me.NIVEL_SUSTANCIAS.MinimumWidth = 100
        Me.NIVEL_SUSTANCIAS.Name = "NIVEL_SUSTANCIAS"
        Me.NIVEL_SUSTANCIAS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NIVEL_SUSTANCIAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SUSTANCIAS
        '
        Me.SUSTANCIAS.FillWeight = 50.97799!
        Me.SUSTANCIAS.HeaderText = "CONSUMO DE SUSTANCIAS"
        Me.SUSTANCIAS.Items.AddRange(New Object() {"TABACO", "BEBIDAS ALCOHOLICAS", "CANNABIS", "COCAINA", "ESTIMULANTES DE TIPO ANFETAMINA", "INHALABLES", "SEDANTES O PASTILLAS PARA DORMIR", "ALUCINOGENOS", "OPIACEOS", "OTRO", "NINGUNO"})
        Me.SUSTANCIAS.MinimumWidth = 150
        Me.SUSTANCIAS.Name = "SUSTANCIAS"
        Me.SUSTANCIAS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SUSTANCIAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CONDUCTAS
        '
        Me.CONDUCTAS.FillWeight = 17.35912!
        Me.CONDUCTAS.HeaderText = "CONDUCTAS ALIM. DE RIESGO"
        Me.CONDUCTAS.Items.AddRange(New Object() {"POSITIVO", "NEGATIVO"})
        Me.CONDUCTAS.MinimumWidth = 200
        Me.CONDUCTAS.Name = "CONDUCTAS"
        Me.CONDUCTAS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CONDUCTAS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'QUITAR
        '
        Me.QUITAR.FillWeight = 5.929886!
        Me.QUITAR.HeaderText = "QUITAR"
        Me.QUITAR.MinimumWidth = 70
        Me.QUITAR.Name = "QUITAR"
        Me.QUITAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.QUITAR.Text = "QUITAR"
        Me.QUITAR.UseColumnTextForButtonValue = True
        '
        'Menu_Copiar
        '
        Me.Menu_Copiar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Pegar})
        Me.Menu_Copiar.Name = "ContextMenuStrip1"
        Me.Menu_Copiar.Size = New System.Drawing.Size(105, 26)
        Me.Menu_Copiar.Text = "Copiar"
        '
        'Menu_Pegar
        '
        Me.Menu_Pegar.Name = "Menu_Pegar"
        Me.Menu_Pegar.Size = New System.Drawing.Size(104, 22)
        Me.Menu_Pegar.Text = "Pegar"
        '
        'BtnAdd
        '
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(1075, 287)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(127, 37)
        Me.BtnAdd.TabIndex = 17
        Me.BtnAdd.Text = "Agregar Fila"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkMagenta
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 671)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1354, 28)
        Me.ToolStrip1.TabIndex = 92
        Me.ToolStrip1.Text = "Titulo"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(532, 25)
        Me.ToolStripLabel2.Text = "Departamento Psicopedagógico.         Sistema de captura de información          " &
    "   "
        '
        'Tamizaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 699)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Tamizaje"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tamizaje"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.PanelResultados.ResumeLayout(False)
        CType(Me.NumEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridTamizaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_Copiar.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridTamizaje As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents CBViolencia As ComboBox
    Friend WithEvents CBAnsiedad As ComboBox
    Friend WithEvents CBDepresion As ComboBox
    Friend WithEvents CBSuicida As ComboBox
    Friend WithEvents NumEdad As NumericUpDown
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CBSustancias As ComboBox
    Friend WithEvents CBConductas As ComboBox
    Friend WithEvents CBConsumo As ComboBox
    Friend WithEvents ComboSexo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip_Titulo As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents BtnReporte As Button
    Friend WithEvents BtnGraficar As Button
    Friend WithEvents PanelResultados As Panel
    Friend WithEvents GBDatos As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PickerFecha As DateTimePicker
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents txtTurno As TextBox
    Friend WithEvents CBPlantel As ComboBox
    Friend WithEvents txtAlumno As TextBox
    Friend WithEvents Menu_Copiar As ContextMenuStrip
    Friend WithEvents Menu_Pegar As ToolStripMenuItem
    Friend WithEvents ALUMNO As DataGridViewTextBoxColumn
    Friend WithEvents EDAD As DataGridViewTextBoxColumn
    Friend WithEvents SEXO As DataGridViewTextBoxColumn
    Friend WithEvents RIESGO_SUICIDA As DataGridViewComboBoxColumn
    Friend WithEvents DEPRESION As DataGridViewComboBoxColumn
    Friend WithEvents ANSIEDAD As DataGridViewComboBoxColumn
    Friend WithEvents VIOLENCIA As DataGridViewComboBoxColumn
    Friend WithEvents NIVEL_SUSTANCIAS As DataGridViewComboBoxColumn
    Friend WithEvents SUSTANCIAS As DataGridViewComboBoxColumn
    Friend WithEvents CONDUCTAS As DataGridViewComboBoxColumn
    Friend WithEvents QUITAR As DataGridViewButtonColumn
End Class
