<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtNumEmp = New System.Windows.Forms.TextBox()
        Me.CBCuenta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.GB_1 = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPlantel = New System.Windows.Forms.TextBox()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.ToolStrip_Titulo.SuspendLayout()
        Me.GB_1.SuspendLayout()
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(716, 45)
        Me.ToolStrip_Titulo.TabIndex = 76
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(185, 42)
        Me.ToolStripLabel1.Text = "Registro de Usuarios"
        '
        'txtNumEmp
        '
        Me.txtNumEmp.BackColor = System.Drawing.Color.White
        Me.txtNumEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtNumEmp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumEmp.Location = New System.Drawing.Point(13, 249)
        Me.txtNumEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumEmp.MaxLength = 4
        Me.txtNumEmp.Name = "txtNumEmp"
        Me.txtNumEmp.Size = New System.Drawing.Size(123, 27)
        Me.txtNumEmp.TabIndex = 1
        Me.txtNumEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBCuenta
        '
        Me.CBCuenta.BackColor = System.Drawing.Color.White
        Me.CBCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCuenta.FormattingEnabled = True
        Me.CBCuenta.Items.AddRange(New Object() {"ADMINISTRADOR", "INVITADO", "RECTORIA", "DIRECCION DES. INTEGRAL"})
        Me.CBCuenta.Location = New System.Drawing.Point(180, 57)
        Me.CBCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCuenta.Name = "CBCuenta"
        Me.CBCuenta.Size = New System.Drawing.Size(336, 27)
        Me.CBCuenta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "TIPO DE CUENTA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 226)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Nº EMPLEADO"
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.SystemColors.Info
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtClave.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(180, 94)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClave.MaxLength = 49
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(205, 34)
        Me.txtClave.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "CONTRASEÑA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(158, 99)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 19)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "PLANTEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 169)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "PUESTO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(158, 133)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 19)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "DEPARTAMENTO"
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.SystemColors.Info
        Me.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPuesto.Location = New System.Drawing.Point(275, 166)
        Me.txtPuesto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPuesto.MaxLength = 100
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.ReadOnly = True
        Me.txtPuesto.Size = New System.Drawing.Size(421, 27)
        Me.txtPuesto.TabIndex = 56
        '
        'GB_1
        '
        Me.GB_1.Controls.Add(Me.txtCorreo)
        Me.GB_1.Controls.Add(Me.Label1)
        Me.GB_1.Controls.Add(Me.BtnGuardar)
        Me.GB_1.Controls.Add(Me.CBCuenta)
        Me.GB_1.Controls.Add(Me.txtClave)
        Me.GB_1.Controls.Add(Me.Label7)
        Me.GB_1.Controls.Add(Me.Label2)
        Me.GB_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_1.Location = New System.Drawing.Point(162, 201)
        Me.GB_1.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_1.Name = "GB_1"
        Me.GB_1.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_1.Size = New System.Drawing.Size(534, 145)
        Me.GB_1.TabIndex = 73
        Me.GB_1.TabStop = False
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCorreo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(180, 22)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreo.MaxLength = 99
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(336, 27)
        Me.txtCorreo.TabIndex = 3
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 19)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "CORREO INSTITUCIONAL"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.Psicopedagogico_net.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(393, 94)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(123, 34)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "NOMBRE"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Psicopedagogico_net.My.Resources.Resources.search1
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(13, 284)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(123, 41)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Psicopedagogico_net.My.Resources.Resources.usuario1
        Me.PictureBox1.Location = New System.Drawing.Point(13, 61)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'txtPlantel
        '
        Me.txtPlantel.BackColor = System.Drawing.SystemColors.Info
        Me.txtPlantel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlantel.Location = New System.Drawing.Point(275, 96)
        Me.txtPlantel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlantel.MaxLength = 100
        Me.txtPlantel.Name = "txtPlantel"
        Me.txtPlantel.ReadOnly = True
        Me.txtPlantel.Size = New System.Drawing.Size(421, 27)
        Me.txtPlantel.TabIndex = 54
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.SystemColors.Info
        Me.txtDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepto.Location = New System.Drawing.Point(275, 131)
        Me.txtDepto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepto.MaxLength = 100
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.Size = New System.Drawing.Size(421, 27)
        Me.txtDepto.TabIndex = 55
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(275, 61)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(421, 27)
        Me.txtNombre.TabIndex = 44
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 371)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Controls.Add(Me.txtNumEmp)
        Me.Controls.Add(Me.GB_1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.txtDepto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPlantel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Usuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        Me.GB_1.ResumeLayout(False)
        Me.GB_1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip_Titulo As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtNumEmp As TextBox
    Friend WithEvents CBCuenta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents GB_1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDepto As TextBox
    Friend WithEvents txtPlantel As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label1 As Label
End Class
