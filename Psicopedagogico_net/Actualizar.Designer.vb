<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox_Hijos = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Embarazo = New System.Windows.Forms.ComboBox()
        Me.cb_plantel = New System.Windows.Forms.ComboBox()
        Me.PlantelesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Planteles_DataSet = New Psicopedagogico_net.Planteles_DataSet()
        Me.piker_fecha = New System.Windows.Forms.DateTimePicker()
        Me.btn_foto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.txt_alumno = New System.Windows.Forms.TextBox()
        Me.pik_foto = New System.Windows.Forms.PictureBox()
        Me.txt_campo1 = New System.Windows.Forms.TextBox()
        Me.lbl_campo1 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.ListBox_datos = New System.Windows.Forms.ListBox()
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_plantel_usuario = New System.Windows.Forms.Label()
        Me.PlantelesTableAdapter = New Psicopedagogico_net.Planteles_DataSetTableAdapters.PlantelesTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PlantelesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planteles_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pik_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_Titulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ComboBox_Hijos)
        Me.Panel1.Controls.Add(Me.ComboBox_Embarazo)
        Me.Panel1.Controls.Add(Me.cb_plantel)
        Me.Panel1.Controls.Add(Me.piker_fecha)
        Me.Panel1.Controls.Add(Me.btn_foto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_actualizar)
        Me.Panel1.Controls.Add(Me.txt_alumno)
        Me.Panel1.Controls.Add(Me.pik_foto)
        Me.Panel1.Controls.Add(Me.txt_campo1)
        Me.Panel1.Controls.Add(Me.lbl_campo1)
        Me.Panel1.Location = New System.Drawing.Point(266, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 414)
        Me.Panel1.TabIndex = 74
        '
        'ComboBox_Hijos
        '
        Me.ComboBox_Hijos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Hijos.FormattingEnabled = True
        Me.ComboBox_Hijos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "Más de 5", "S/I"})
        Me.ComboBox_Hijos.Location = New System.Drawing.Point(149, 285)
        Me.ComboBox_Hijos.Name = "ComboBox_Hijos"
        Me.ComboBox_Hijos.Size = New System.Drawing.Size(186, 27)
        Me.ComboBox_Hijos.TabIndex = 82
        Me.ComboBox_Hijos.Visible = False
        '
        'ComboBox_Embarazo
        '
        Me.ComboBox_Embarazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Embarazo.FormattingEnabled = True
        Me.ComboBox_Embarazo.Items.AddRange(New Object() {"NO", "ACTUALMENTE", "ABORTO", "N/A"})
        Me.ComboBox_Embarazo.Location = New System.Drawing.Point(149, 285)
        Me.ComboBox_Embarazo.Name = "ComboBox_Embarazo"
        Me.ComboBox_Embarazo.Size = New System.Drawing.Size(186, 27)
        Me.ComboBox_Embarazo.TabIndex = 81
        Me.ComboBox_Embarazo.Visible = False
        '
        'cb_plantel
        '
        Me.cb_plantel.DataSource = Me.PlantelesBindingSource
        Me.cb_plantel.DisplayMember = "Sede"
        Me.cb_plantel.DropDownHeight = 130
        Me.cb_plantel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_plantel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_plantel.FormattingEnabled = True
        Me.cb_plantel.IntegralHeight = False
        Me.cb_plantel.Location = New System.Drawing.Point(10, 285)
        Me.cb_plantel.Name = "cb_plantel"
        Me.cb_plantel.Size = New System.Drawing.Size(325, 26)
        Me.cb_plantel.TabIndex = 80
        Me.cb_plantel.ValueMember = "Sede"
        Me.cb_plantel.Visible = False
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
        'piker_fecha
        '
        Me.piker_fecha.Location = New System.Drawing.Point(159, 241)
        Me.piker_fecha.Name = "piker_fecha"
        Me.piker_fecha.Size = New System.Drawing.Size(176, 27)
        Me.piker_fecha.TabIndex = 79
        Me.piker_fecha.Visible = False
        '
        'btn_foto
        '
        Me.btn_foto.Image = Global.Psicopedagogico_net.My.Resources.Resources.pictures
        Me.btn_foto.Location = New System.Drawing.Point(240, 114)
        Me.btn_foto.Name = "btn_foto"
        Me.btn_foto.Size = New System.Drawing.Size(41, 33)
        Me.btn_foto.TabIndex = 78
        Me.btn_foto.UseVisualStyleBackColor = True
        Me.btn_foto.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "NOMBRE DEL ALUMNO"
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Enabled = False
        Me.btn_actualizar.Image = Global.Psicopedagogico_net.My.Resources.Resources.refresh
        Me.btn_actualizar.Location = New System.Drawing.Point(116, 365)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(118, 40)
        Me.btn_actualizar.TabIndex = 76
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'txt_alumno
        '
        Me.txt_alumno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_alumno.Enabled = False
        Me.txt_alumno.Location = New System.Drawing.Point(10, 182)
        Me.txt_alumno.MaxLength = 99
        Me.txt_alumno.Multiline = True
        Me.txt_alumno.Name = "txt_alumno"
        Me.txt_alumno.Size = New System.Drawing.Size(325, 47)
        Me.txt_alumno.TabIndex = 75
        Me.txt_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pik_foto
        '
        Me.pik_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pik_foto.Image = Global.Psicopedagogico_net.My.Resources.Resources.vidas
        Me.pik_foto.Location = New System.Drawing.Point(116, 13)
        Me.pik_foto.Name = "pik_foto"
        Me.pik_foto.Size = New System.Drawing.Size(118, 134)
        Me.pik_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pik_foto.TabIndex = 0
        Me.pik_foto.TabStop = False
        '
        'txt_campo1
        '
        Me.txt_campo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_campo1.Location = New System.Drawing.Point(10, 269)
        Me.txt_campo1.MaxLength = 500
        Me.txt_campo1.Multiline = True
        Me.txt_campo1.Name = "txt_campo1"
        Me.txt_campo1.Size = New System.Drawing.Size(325, 90)
        Me.txt_campo1.TabIndex = 9
        '
        'lbl_campo1
        '
        Me.lbl_campo1.AutoSize = True
        Me.lbl_campo1.Location = New System.Drawing.Point(6, 247)
        Me.lbl_campo1.Name = "lbl_campo1"
        Me.lbl_campo1.Size = New System.Drawing.Size(158, 19)
        Me.lbl_campo1.TabIndex = 14
        Me.lbl_campo1.Text = "CAMPO A ACTUALIZAR"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(210, 85)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(42, 28)
        Me.btn_ok.TabIndex = 73
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 19)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "¿QUE DATOS DESEA ACTUALIZAR?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "FOLIO:"
        '
        'txt_folio
        '
        Me.txt_folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_folio.Location = New System.Drawing.Point(12, 85)
        Me.txt_folio.MaxLength = 50
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(193, 27)
        Me.txt_folio.TabIndex = 68
        '
        'ListBox_datos
        '
        Me.ListBox_datos.FormattingEnabled = True
        Me.ListBox_datos.ItemHeight = 19
        Me.ListBox_datos.Items.AddRange(New Object() {"FOLIO", "MATRICULA", "NOMBRE", "EDAD", "CURP", "DIRECCION", "TELEFONO", "CIUDAD", "PLANTEL", "GRADO", "ESPECIALIDAD", "TURNO", "DISCAPACIDAD", "ADICCION", "ENFERMEDAD", "TRABAJA", "SEXO", "VIVE_CON", "FOTOGRAFIA", "P_VIVE", "P_NOMBRE", "P_EDAD", "P_GRADO", "P_EDOCIVIL", "P_DISCAPACIDAD", "P_ADICCION", "P_ENFERMEDAD", "P_RELIGION", "P_TRABAJA", "P_LABOR", "M_VIVE", "M_NOMBRE", "M_EDAD", "M_GRADO", "M_EDOCIVIL", "M_DISCAPACIDAD", "M_ADICCION", "M_ENFERMEDAD", "M_RELIGION", "M_TRABAJA", "M_LABOR", "HERMANOS", "VIVE EN", "HABITANTES", "MOTIVO_CONSULTA", "FECHA CANALIZACION", "MOTIVO CANALIZACION", "LUGAR CANALIZACION", "ATENCION", "UNIDAD", "VIOLENCIA", "CONSUMO_SUSTANCIAS", "DEPRESION", "TRANSTORNOS_ALIMENTACION", "DEFICIT_ATENCION", "INTERVENCION_CRISIS", "Embarazo", "Hijos"})
        Me.ListBox_datos.Location = New System.Drawing.Point(12, 153)
        Me.ListBox_datos.Name = "ListBox_datos"
        Me.ListBox_datos.Size = New System.Drawing.Size(240, 308)
        Me.ListBox_datos.TabIndex = 82
        '
        'ToolStrip_Titulo
        '
        Me.ToolStrip_Titulo.AutoSize = False
        Me.ToolStrip_Titulo.BackColor = System.Drawing.Color.DarkMagenta
        Me.ToolStrip_Titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_Titulo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip_Titulo.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_Titulo.Name = "ToolStrip_Titulo"
        Me.ToolStrip_Titulo.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip_Titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(626, 44)
        Me.ToolStrip_Titulo.TabIndex = 83
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(305, 41)
        Me.ToolStripLabel1.Text = "Actualizar información del alumno"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_plantel_usuario
        '
        Me.lbl_plantel_usuario.AutoSize = True
        Me.lbl_plantel_usuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plantel_usuario.Location = New System.Drawing.Point(323, 9)
        Me.lbl_plantel_usuario.Name = "lbl_plantel_usuario"
        Me.lbl_plantel_usuario.Size = New System.Drawing.Size(17, 19)
        Me.lbl_plantel_usuario.TabIndex = 85
        Me.lbl_plantel_usuario.Text = "_"
        Me.lbl_plantel_usuario.Visible = False
        '
        'PlantelesTableAdapter
        '
        Me.PlantelesTableAdapter.ClearBeforeFill = True
        '
        'Actualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(626, 466)
        Me.Controls.Add(Me.lbl_plantel_usuario)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Controls.Add(Me.ListBox_datos)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_folio)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Actualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PlantelesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planteles_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pik_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_campo1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_campo1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents txt_alumno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox_datos As System.Windows.Forms.ListBox
    Friend WithEvents pik_foto As System.Windows.Forms.PictureBox
    Friend WithEvents btn_foto As System.Windows.Forms.Button
    Friend WithEvents piker_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_plantel_usuario As System.Windows.Forms.Label
    Friend WithEvents cb_plantel As System.Windows.Forms.ComboBox
    Friend WithEvents Planteles_DataSet As Psicopedagogico_net.Planteles_DataSet
    Friend WithEvents PlantelesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlantelesTableAdapter As Psicopedagogico_net.Planteles_DataSetTableAdapters.PlantelesTableAdapter
    Friend WithEvents ComboBox_Hijos As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Embarazo As System.Windows.Forms.ComboBox
End Class
