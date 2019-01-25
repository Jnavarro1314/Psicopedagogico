<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDeUsuarios
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
        Me.GB_3 = New System.Windows.Forms.GroupBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.CB_cuenta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.chk_mostrar = New System.Windows.Forms.CheckBox()
        Me.txt_confirmar_clave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GB_2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CB_Plantel = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_Depto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_puesto = New System.Windows.Forms.TextBox()
        Me.GB_1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip_Titulo.SuspendLayout()
        Me.GB_3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(680, 44)
        Me.ToolStrip_Titulo.TabIndex = 70
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(185, 41)
        Me.ToolStripLabel1.Text = "Registro de Usuarios"
        '
        'GB_3
        '
        Me.GB_3.Controls.Add(Me.txt_usuario)
        Me.GB_3.Controls.Add(Me.CB_cuenta)
        Me.GB_3.Controls.Add(Me.Label2)
        Me.GB_3.Controls.Add(Me.PictureBox3)
        Me.GB_3.Controls.Add(Me.chk_mostrar)
        Me.GB_3.Controls.Add(Me.txt_confirmar_clave)
        Me.GB_3.Controls.Add(Me.Label1)
        Me.GB_3.Controls.Add(Me.Label8)
        Me.GB_3.Controls.Add(Me.txt_clave)
        Me.GB_3.Controls.Add(Me.Label7)
        Me.GB_3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_3.Location = New System.Drawing.Point(364, 50)
        Me.GB_3.Name = "GB_3"
        Me.GB_3.Size = New System.Drawing.Size(297, 311)
        Me.GB_3.TabIndex = 69
        Me.GB_3.TabStop = False
        Me.GB_3.Text = "DATOS DE USUARIO"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.White
        Me.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_usuario.Location = New System.Drawing.Point(82, 127)
        Me.txt_usuario.MaxLength = 49
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(199, 27)
        Me.txt_usuario.TabIndex = 54
        '
        'CB_cuenta
        '
        Me.CB_cuenta.BackColor = System.Drawing.Color.White
        Me.CB_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_cuenta.FormattingEnabled = True
        Me.CB_cuenta.Items.AddRange(New Object() {"ADMINISTRADOR", "INVITADO", "RECTORIA", "DIRECCION DES. INTEGRAL"})
        Me.CB_cuenta.Location = New System.Drawing.Point(82, 60)
        Me.CB_cuenta.Name = "CB_cuenta"
        Me.CB_cuenta.Size = New System.Drawing.Size(199, 27)
        Me.CB_cuenta.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "TIPO DE CUENTA"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Psicopedagogico_net.My.Resources.Resources.llves
        Me.PictureBox3.Location = New System.Drawing.Point(6, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 64
        Me.PictureBox3.TabStop = False
        '
        'chk_mostrar
        '
        Me.chk_mostrar.AutoSize = True
        Me.chk_mostrar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_mostrar.Location = New System.Drawing.Point(82, 262)
        Me.chk_mostrar.Name = "chk_mostrar"
        Me.chk_mostrar.Size = New System.Drawing.Size(153, 19)
        Me.chk_mostrar.TabIndex = 62
        Me.chk_mostrar.Text = "MOSTRAR CONTRASEÑA"
        Me.chk_mostrar.UseVisualStyleBackColor = True
        '
        'txt_confirmar_clave
        '
        Me.txt_confirmar_clave.BackColor = System.Drawing.Color.White
        Me.txt_confirmar_clave.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_confirmar_clave.Location = New System.Drawing.Point(82, 229)
        Me.txt_confirmar_clave.MaxLength = 49
        Me.txt_confirmar_clave.Name = "txt_confirmar_clave"
        Me.txt_confirmar_clave.Size = New System.Drawing.Size(199, 27)
        Me.txt_confirmar_clave.TabIndex = 58
        Me.txt_confirmar_clave.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 19)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "CONFIRMAR CONTRASEÑA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "USUARIO"
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.Color.White
        Me.txt_clave.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_clave.Location = New System.Drawing.Point(82, 177)
        Me.txt_clave.MaxLength = 49
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(199, 27)
        Me.txt_clave.TabIndex = 55
        Me.txt_clave.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "CONTRASEÑA"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Image = Global.Psicopedagogico_net.My.Resources.Resources.apply
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.Location = New System.Drawing.Point(462, 376)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(95, 40)
        Me.btn_aceptar.TabIndex = 65
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = Global.Psicopedagogico_net.My.Resources.Resources.cancel
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(563, 376)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 40)
        Me.btn_cancelar.TabIndex = 66
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'GB_2
        '
        Me.GB_2.Controls.Add(Me.PictureBox2)
        Me.GB_2.Controls.Add(Me.CB_Plantel)
        Me.GB_2.Controls.Add(Me.Label16)
        Me.GB_2.Controls.Add(Me.CB_Depto)
        Me.GB_2.Controls.Add(Me.Label6)
        Me.GB_2.Controls.Add(Me.Label15)
        Me.GB_2.Controls.Add(Me.txt_puesto)
        Me.GB_2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_2.Location = New System.Drawing.Point(12, 183)
        Me.GB_2.Name = "GB_2"
        Me.GB_2.Size = New System.Drawing.Size(334, 178)
        Me.GB_2.TabIndex = 68
        Me.GB_2.TabStop = False
        Me.GB_2.Text = "DATOS LABORALES"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Psicopedagogico_net.My.Resources.Resources.trabajo
        Me.PictureBox2.Location = New System.Drawing.Point(6, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'CB_Plantel
        '
        Me.CB_Plantel.BackColor = System.Drawing.Color.White
        Me.CB_Plantel.DropDownHeight = 130
        Me.CB_Plantel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Plantel.FormattingEnabled = True
        Me.CB_Plantel.IntegralHeight = False
        Me.CB_Plantel.Location = New System.Drawing.Point(69, 44)
        Me.CB_Plantel.Name = "CB_Plantel"
        Me.CB_Plantel.Size = New System.Drawing.Size(247, 27)
        Me.CB_Plantel.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(66, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 19)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "PLANTEL"
        '
        'CB_Depto
        '
        Me.CB_Depto.BackColor = System.Drawing.Color.White
        Me.CB_Depto.DropDownHeight = 130
        Me.CB_Depto.FormattingEnabled = True
        Me.CB_Depto.IntegralHeight = False
        Me.CB_Depto.Items.AddRange(New Object() {"SEDE FORANEA", "ADMINISTRACION Y FINANZAS", "CAPITAL HUMANO", "COMPRAS", "CONTABILIDAD", "DESARROLLO E INOVACION", "DESARROLLO INTEGRAL", "DIRECCION ACADEMICA", "DIRECCION DE IMAGEN Y COMUNICACION", "EDUCACION MEDIA", "EDUCACION SUPERIOR", "EXTENCION Y DIBULGACION", "INTENDENCIA", "MANTENIMIENTO E INFRAESTRUCTURA", "PLANEACION", "RECTORIA", "RELACIONES LABORALES", "SEGURIDAD", "SERVICIOS ESCOLARES", "TECNOLOGIAS DE LA INFORMACION", "TESORERIA", "VINCULACION Y DIFUSION"})
        Me.CB_Depto.Location = New System.Drawing.Point(69, 90)
        Me.CB_Depto.Name = "CB_Depto"
        Me.CB_Depto.Size = New System.Drawing.Size(247, 27)
        Me.CB_Depto.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "PUESTO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 19)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "DEPARTAMENTO"
        '
        'txt_puesto
        '
        Me.txt_puesto.BackColor = System.Drawing.Color.White
        Me.txt_puesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_puesto.Location = New System.Drawing.Point(11, 136)
        Me.txt_puesto.MaxLength = 49
        Me.txt_puesto.Name = "txt_puesto"
        Me.txt_puesto.Size = New System.Drawing.Size(306, 27)
        Me.txt_puesto.TabIndex = 52
        '
        'GB_1
        '
        Me.GB_1.Controls.Add(Me.PictureBox1)
        Me.GB_1.Controls.Add(Me.Label4)
        Me.GB_1.Controls.Add(Me.txt_nombre)
        Me.GB_1.Controls.Add(Me.txt_apellidos)
        Me.GB_1.Controls.Add(Me.Label5)
        Me.GB_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_1.Location = New System.Drawing.Point(12, 50)
        Me.GB_1.Name = "GB_1"
        Me.GB_1.Size = New System.Drawing.Size(334, 127)
        Me.GB_1.TabIndex = 67
        Me.GB_1.TabStop = False
        Me.GB_1.Text = "DATOS PERSONALES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Psicopedagogico_net.My.Resources.Resources.usuario1
        Me.PictureBox1.Location = New System.Drawing.Point(11, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "NOMBRE"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.White
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Location = New System.Drawing.Point(69, 41)
        Me.txt_nombre.MaxLength = 49
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(247, 27)
        Me.txt_nombre.TabIndex = 44
        '
        'txt_apellidos
        '
        Me.txt_apellidos.BackColor = System.Drawing.Color.White
        Me.txt_apellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos.Location = New System.Drawing.Point(69, 89)
        Me.txt_apellidos.MaxLength = 49
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(247, 27)
        Me.txt_apellidos.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "APELLIDOS"
        '
        'RegistroDeUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 429)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Controls.Add(Me.GB_3)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.GB_2)
        Me.Controls.Add(Me.GB_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RegistroDeUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro De Usuarios"
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        Me.GB_3.ResumeLayout(False)
        Me.GB_3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_2.ResumeLayout(False)
        Me.GB_2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_1.ResumeLayout(False)
        Me.GB_1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GB_3 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_cuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents chk_mostrar As System.Windows.Forms.CheckBox
    Friend WithEvents txt_confirmar_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GB_2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CB_Plantel As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CB_Depto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_puesto As System.Windows.Forms.TextBox
    Friend WithEvents GB_1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
