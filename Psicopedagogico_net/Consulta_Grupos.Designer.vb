<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Grupos
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
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Grid_ConsultaGrupos = New System.Windows.Forms.DataGridView()
        Me.SELECCIONA = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tema = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_plantel = New System.Windows.Forms.ComboBox()
        Me.DsGrupos = New Psicopedagogico_net.DsGrupos()
        Me.DsGruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_fecha2 = New System.Windows.Forms.TextBox()
        Me.txt_fecha1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Final = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip_Titulo.SuspendLayout()
        CType(Me.Grid_ConsultaGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DsGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(1276, 44)
        Me.ToolStrip_Titulo.TabIndex = 16
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(255, 41)
        Me.ToolStripLabel1.Text = "Consultas Atención a Grupos"
        '
        'Grid_ConsultaGrupos
        '
        Me.Grid_ConsultaGrupos.AllowUserToAddRows = False
        Me.Grid_ConsultaGrupos.AllowUserToDeleteRows = False
        Me.Grid_ConsultaGrupos.AllowUserToOrderColumns = True
        Me.Grid_ConsultaGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grid_ConsultaGrupos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Grid_ConsultaGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SELECCIONA})
        Me.Grid_ConsultaGrupos.Location = New System.Drawing.Point(296, 41)
        Me.Grid_ConsultaGrupos.Name = "Grid_ConsultaGrupos"
        Me.Grid_ConsultaGrupos.ReadOnly = True
        Me.Grid_ConsultaGrupos.Size = New System.Drawing.Size(980, 586)
        Me.Grid_ConsultaGrupos.TabIndex = 17
        '
        'SELECCIONA
        '
        Me.SELECCIONA.HeaderText = "SELECCIONA"
        Me.SELECCIONA.Name = "SELECCIONA"
        Me.SELECCIONA.ReadOnly = True
        Me.SELECCIONA.Text = "SELECCIONA"
        Me.SELECCIONA.UseColumnTextForButtonValue = True
        Me.SELECCIONA.Width = 97
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_fecha1)
        Me.Panel1.Controls.Add(Me.Btn_buscar)
        Me.Panel1.Controls.Add(Me.Btn_Imprimir)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_tema)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_fecha2)
        Me.Panel1.Controls.Add(Me.cb_plantel)
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 586)
        Me.Panel1.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(20, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 59)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Selecciona una opción de búsqueda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y a continuación, da clic en el botón " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'Filt" & _
    "rar'."
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Image = Global.Psicopedagogico_net.My.Resources.Resources.search1
        Me.Btn_buscar.Location = New System.Drawing.Point(66, 521)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(89, 40)
        Me.Btn_buscar.TabIndex = 31
        Me.Btn_buscar.Text = "Filtrar"
        Me.Btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Image = Global.Psicopedagogico_net.My.Resources.Resources.print
        Me.Btn_Imprimir.Location = New System.Drawing.Point(161, 521)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(104, 40)
        Me.Btn_Imprimir.TabIndex = 30
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "TEMA"
        '
        'txt_tema
        '
        Me.txt_tema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tema.Location = New System.Drawing.Point(17, 183)
        Me.txt_tema.MaxLength = 99
        Me.txt_tema.Multiline = True
        Me.txt_tema.Name = "txt_tema"
        Me.txt_tema.Size = New System.Drawing.Size(248, 64)
        Me.txt_tema.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "PLANTEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "FIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "INICIO"
        '
        'cb_plantel
        '
        Me.cb_plantel.DisplayMember = "Sede"
        Me.cb_plantel.DropDownHeight = 130
        Me.cb_plantel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plantel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_plantel.FormattingEnabled = True
        Me.cb_plantel.IntegralHeight = False
        Me.cb_plantel.Location = New System.Drawing.Point(17, 120)
        Me.cb_plantel.Name = "cb_plantel"
        Me.cb_plantel.Size = New System.Drawing.Size(248, 26)
        Me.cb_plantel.TabIndex = 4
        Me.cb_plantel.ValueMember = "Sede"
        '
        'DsGrupos
        '
        Me.DsGrupos.DataSetName = "DsGrupos"
        Me.DsGrupos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsGruposBindingSource
        '
        Me.DsGruposBindingSource.DataSource = Me.DsGrupos
        Me.DsGruposBindingSource.Position = 0
        '
        'txt_fecha2
        '
        Me.txt_fecha2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha2.Enabled = False
        Me.txt_fecha2.Location = New System.Drawing.Point(66, 476)
        Me.txt_fecha2.MaxLength = 99
        Me.txt_fecha2.Name = "txt_fecha2"
        Me.txt_fecha2.Size = New System.Drawing.Size(199, 27)
        Me.txt_fecha2.TabIndex = 21
        '
        'txt_fecha1
        '
        Me.txt_fecha1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fecha1.Enabled = False
        Me.txt_fecha1.Location = New System.Drawing.Point(66, 443)
        Me.txt_fecha1.MaxLength = 99
        Me.txt_fecha1.Name = "txt_fecha1"
        Me.txt_fecha1.Size = New System.Drawing.Size(199, 27)
        Me.txt_fecha1.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Inicio)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Final)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 252)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 101)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'DateTimePicker_Inicio
        '
        Me.DateTimePicker_Inicio.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Inicio.Location = New System.Drawing.Point(94, 19)
        Me.DateTimePicker_Inicio.Name = "DateTimePicker_Inicio"
        Me.DateTimePicker_Inicio.Size = New System.Drawing.Size(113, 27)
        Me.DateTimePicker_Inicio.TabIndex = 407
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label32.Location = New System.Drawing.Point(44, 23)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 19)
        Me.Label32.TabIndex = 409
        Me.Label32.Text = "Inicio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(48, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 19)
        Me.Label16.TabIndex = 410
        Me.Label16.Text = "Final"
        '
        'DateTimePicker_Final
        '
        Me.DateTimePicker_Final.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DateTimePicker_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Final.Location = New System.Drawing.Point(94, 52)
        Me.DateTimePicker_Final.Name = "DateTimePicker_Final"
        Me.DateTimePicker_Final.Size = New System.Drawing.Size(113, 27)
        Me.DateTimePicker_Final.TabIndex = 408
        '
        'Consulta_Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1276, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grid_ConsultaGrupos)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Consulta_Grupos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta_Grupos"
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        CType(Me.Grid_ConsultaGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DsGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Grid_ConsultaGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents SELECCIONA As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_plantel As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_tema As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents Btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DsGrupos As DsGrupos
    Friend WithEvents DsGruposBindingSource As BindingSource
    Friend WithEvents txt_fecha1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Final As System.Windows.Forms.DateTimePicker
End Class
