<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Asistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Asistencia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_Datos = New System.Windows.Forms.Panel()
        Me.cb_plantel = New System.Windows.Forms.ComboBox()
        Me.PlantelesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Planteles_DataSet = New Psicopedagogico_net.Planteles_DataSet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre_alumno = New System.Windows.Forms.TextBox()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip10 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel10 = New System.Windows.Forms.ToolStripLabel()
        Me.CB_lugar = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Panel_escolares_alumno = New System.Windows.Forms.Panel()
        Me.DataGridView_Sesiones = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Consulta = New System.Windows.Forms.Button()
        Me.DateTimePicker_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Final = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PlantelesTableAdapter = New Psicopedagogico_net.Planteles_DataSetTableAdapters.PlantelesTableAdapter()
        Me.DataSet_Consultas = New Psicopedagogico_net.DataSet_Consultas()
        Me.PsRegistroAsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel_Datos.SuspendLayout()
        CType(Me.PlantelesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planteles_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip10.SuspendLayout()
        Me.Panel_escolares_alumno.SuspendLayout()
        CType(Me.DataGridView_Sesiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataSet_Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsRegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Datos
        '
        Me.Panel_Datos.BackColor = System.Drawing.Color.White
        Me.Panel_Datos.Controls.Add(Me.cb_plantel)
        Me.Panel_Datos.Controls.Add(Me.Label11)
        Me.Panel_Datos.Controls.Add(Me.Btn_Guardar)
        Me.Panel_Datos.Controls.Add(Me.txt_matricula)
        Me.Panel_Datos.Controls.Add(Me.Label49)
        Me.Panel_Datos.Controls.Add(Me.Label2)
        Me.Panel_Datos.Controls.Add(Me.txt_nombre_alumno)
        Me.Panel_Datos.Controls.Add(Me.txt_folio)
        Me.Panel_Datos.Controls.Add(Me.Label1)
        Me.Panel_Datos.Controls.Add(Me.ToolStrip10)
        Me.Panel_Datos.Controls.Add(Me.CB_lugar)
        Me.Panel_Datos.Controls.Add(Me.Label52)
        Me.Panel_Datos.Location = New System.Drawing.Point(2, 1)
        Me.Panel_Datos.Name = "Panel_Datos"
        Me.Panel_Datos.Size = New System.Drawing.Size(495, 188)
        Me.Panel_Datos.TabIndex = 11
        '
        'cb_plantel
        '
        Me.cb_plantel.DataSource = Me.PlantelesBindingSource
        Me.cb_plantel.DisplayMember = "Sede"
        Me.cb_plantel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plantel.FormattingEnabled = True
        Me.cb_plantel.Location = New System.Drawing.Point(106, 84)
        Me.cb_plantel.Name = "cb_plantel"
        Me.cb_plantel.Size = New System.Drawing.Size(373, 21)
        Me.cb_plantel.TabIndex = 84
        Me.cb_plantel.Tag = "Cn"
        Me.cb_plantel.ValueMember = "Sede"
        '
        'PlantelesBindingSource
        '
        Me.PlantelesBindingSource.DataMember = "Planteles"
        Me.PlantelesBindingSource.DataSource = Me.Planteles_DataSet
        '
        'Planteles_DataSet
        '
        Me.Planteles_DataSet.DataSetName = "Planteles_DataSet"
        Me.Planteles_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "PLANTEL"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(377, 138)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(102, 40)
        Me.Btn_Guardar.TabIndex = 83
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'txt_matricula
        '
        Me.txt_matricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_matricula.Location = New System.Drawing.Point(106, 32)
        Me.txt_matricula.MaxLength = 10
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(160, 20)
        Me.txt_matricula.TabIndex = 75
        Me.txt_matricula.Tag = "Cn"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(30, 35)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(69, 13)
        Me.Label49.TabIndex = 80
        Me.Label49.Text = "MATRICULA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "NOMBRE"
        '
        'txt_nombre_alumno
        '
        Me.txt_nombre_alumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_alumno.Location = New System.Drawing.Point(106, 58)
        Me.txt_nombre_alumno.MaxLength = 99
        Me.txt_nombre_alumno.Name = "txt_nombre_alumno"
        Me.txt_nombre_alumno.Size = New System.Drawing.Size(373, 20)
        Me.txt_nombre_alumno.TabIndex = 79
        Me.txt_nombre_alumno.Tag = "Cn"
        '
        'txt_folio
        '
        Me.txt_folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_folio.Location = New System.Drawing.Point(319, 32)
        Me.txt_folio.MaxLength = 50
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(160, 20)
        Me.txt_folio.TabIndex = 77
        Me.txt_folio.Tag = "Cn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "FOLIO"
        '
        'ToolStrip10
        '
        Me.ToolStrip10.AutoSize = False
        Me.ToolStrip10.BackColor = System.Drawing.Color.DarkMagenta
        Me.ToolStrip10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel10})
        Me.ToolStrip10.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip10.Name = "ToolStrip10"
        Me.ToolStrip10.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip10.Size = New System.Drawing.Size(495, 30)
        Me.ToolStrip10.TabIndex = 74
        Me.ToolStrip10.Text = "Titulo"
        '
        'ToolStripLabel10
        '
        Me.ToolStripLabel10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel10.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel10.Name = "ToolStripLabel10"
        Me.ToolStripLabel10.Size = New System.Drawing.Size(117, 27)
        Me.ToolStripLabel10.Text = "DATOS ALUMNO"
        '
        'CB_lugar
        '
        Me.CB_lugar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_lugar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_lugar.FormattingEnabled = True
        Me.CB_lugar.Items.AddRange(New Object() {"C.A.I.S.E.S ", "U.M.A.P.S. ", "UNEME-CAPA", "U.M.A.P.S. ", "INSTITUTO MUNICIPAL DE LA JUVENTUD", "CASA DE APOYO A LA MUJER A.C", "CENTRO DE INTEGRACIÓN JUVENIL A.C.", "INSTITUTO MUNICIPAL DE LA MUJER", "DIF", "IMSS", "ISSSTE", "S/I", "OTRO"})
        Me.CB_lugar.Location = New System.Drawing.Point(135, 111)
        Me.CB_lugar.MaxLength = 99
        Me.CB_lugar.Name = "CB_lugar"
        Me.CB_lugar.Size = New System.Drawing.Size(344, 21)
        Me.CB_lugar.TabIndex = 3
        Me.CB_lugar.Tag = "Cn"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(9, 114)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(120, 13)
        Me.Label52.TabIndex = 49
        Me.Label52.Text = "LUGAR DE ATENCIÓN"
        '
        'Panel_escolares_alumno
        '
        Me.Panel_escolares_alumno.BackColor = System.Drawing.Color.White
        Me.Panel_escolares_alumno.Controls.Add(Me.DataGridView_Sesiones)
        Me.Panel_escolares_alumno.Controls.Add(Me.GroupBox1)
        Me.Panel_escolares_alumno.Controls.Add(Me.ToolStrip1)
        Me.Panel_escolares_alumno.Location = New System.Drawing.Point(2, 195)
        Me.Panel_escolares_alumno.Name = "Panel_escolares_alumno"
        Me.Panel_escolares_alumno.Size = New System.Drawing.Size(495, 396)
        Me.Panel_escolares_alumno.TabIndex = 12
        '
        'DataGridView_Sesiones
        '
        Me.DataGridView_Sesiones.AllowUserToAddRows = False
        Me.DataGridView_Sesiones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView_Sesiones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Sesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView_Sesiones.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_Sesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Sesiones.Location = New System.Drawing.Point(0, 88)
        Me.DataGridView_Sesiones.Name = "DataGridView_Sesiones"
        Me.DataGridView_Sesiones.ReadOnly = True
        Me.DataGridView_Sesiones.RowHeadersVisible = False
        Me.DataGridView_Sesiones.Size = New System.Drawing.Size(489, 286)
        Me.DataGridView_Sesiones.TabIndex = 421
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Consulta)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Inicio)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Final)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 51)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'Button_Consulta
        '
        Me.Button_Consulta.Image = CType(resources.GetObject("Button_Consulta.Image"), System.Drawing.Image)
        Me.Button_Consulta.Location = New System.Drawing.Point(374, 9)
        Me.Button_Consulta.Name = "Button_Consulta"
        Me.Button_Consulta.Size = New System.Drawing.Size(102, 40)
        Me.Button_Consulta.TabIndex = 411
        Me.Button_Consulta.Text = "Consultar"
        Me.Button_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Consulta.UseVisualStyleBackColor = True
        '
        'DateTimePicker_Inicio
        '
        Me.DateTimePicker_Inicio.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Inicio.Location = New System.Drawing.Point(44, 14)
        Me.DateTimePicker_Inicio.Name = "DateTimePicker_Inicio"
        Me.DateTimePicker_Inicio.Size = New System.Drawing.Size(113, 23)
        Me.DateTimePicker_Inicio.TabIndex = 407
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 15)
        Me.Label32.TabIndex = 409
        Me.Label32.Text = "Inicio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(168, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 15)
        Me.Label16.TabIndex = 410
        Me.Label16.Text = "Final"
        '
        'DateTimePicker_Final
        '
        Me.DateTimePicker_Final.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Final.Location = New System.Drawing.Point(209, 14)
        Me.DateTimePicker_Final.Name = "DateTimePicker_Final"
        Me.DateTimePicker_Final.Size = New System.Drawing.Size(113, 23)
        Me.DateTimePicker_Final.TabIndex = 408
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
        Me.ToolStrip1.Size = New System.Drawing.Size(495, 30)
        Me.ToolStrip1.TabIndex = 71
        Me.ToolStrip1.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 27)
        Me.ToolStripLabel1.Text = "REGISTROS"
        '
        'PlantelesTableAdapter
        '
        Me.PlantelesTableAdapter.ClearBeforeFill = True
        '
        'DataSet_Consultas
        '
        Me.DataSet_Consultas.DataSetName = "DataSet_Consultas"
        Me.DataSet_Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PsRegistroAsistenciaBindingSource
        '
        Me.PsRegistroAsistenciaBindingSource.DataMember = "Ps_Registro_Asistencia"
        Me.PsRegistroAsistenciaBindingSource.DataSource = Me.DataSet_Consultas
        '
        'Registro_Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 594)
        Me.Controls.Add(Me.Panel_escolares_alumno)
        Me.Controls.Add(Me.Panel_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registro_Asistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE ASISTENCIA AL SERVICIO DE SALUD"
        Me.Panel_Datos.ResumeLayout(False)
        Me.Panel_Datos.PerformLayout()
        CType(Me.PlantelesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planteles_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip10.ResumeLayout(False)
        Me.ToolStrip10.PerformLayout()
        Me.Panel_escolares_alumno.ResumeLayout(False)
        CType(Me.DataGridView_Sesiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataSet_Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsRegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Datos As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip10 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CB_lugar As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_escolares_alumno As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cb_plantel As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Planteles_DataSet As Psicopedagogico_net.Planteles_DataSet
    Friend WithEvents PlantelesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlantelesTableAdapter As Psicopedagogico_net.Planteles_DataSetTableAdapters.PlantelesTableAdapter
    Friend WithEvents DataGridView_Sesiones As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Consulta As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Final As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataSet_Consultas As Psicopedagogico_net.DataSet_Consultas
    Friend WithEvents PsRegistroAsistenciaBindingSource As System.Windows.Forms.BindingSource
End Class
