<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notificacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notificacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip_Titulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SOLO PERSONAL AUTORIZADO RESGUARDADO POR LA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LEY FEDERAL DE PROTECCIÓN DE DATOS P" &
    "ERSONALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(749, 44)
        Me.ToolStrip_Titulo.TabIndex = 14
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(115, 41)
        Me.ToolStripLabel1.Text = "Notificación"
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Image = Global.Psicopedagogico_net.My.Resources.Resources.apply
        Me.btn_iniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_iniciar.Location = New System.Drawing.Point(623, 15)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(114, 40)
        Me.btn_iniciar.TabIndex = 6
        Me.btn_iniciar.Text = "ACEPTAR"
        Me.btn_iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(609, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(130, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Instituto Universitario del Centro de México"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Psicopedagogico_net.My.Resources.Resources.logo_psicop
        Me.PictureBox1.Location = New System.Drawing.Point(12, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(727, 357)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_iniciar)
        Me.Panel1.Location = New System.Drawing.Point(-5, 399)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 71)
        Me.Panel1.TabIndex = 82
        '
        'Notificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notificacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_iniciar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
