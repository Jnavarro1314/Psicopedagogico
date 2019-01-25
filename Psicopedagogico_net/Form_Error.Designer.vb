<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Error
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Error))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Guardar = New System.Windows.Forms.Button()
        Me.RichTextBox_Mensaje = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Error = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox_Error = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button_Guardar)
        Me.Panel1.Controls.Add(Me.RichTextBox_Mensaje)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label_Error)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.RichTextBox_Error)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 539)
        Me.Panel1.TabIndex = 372
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 372
        Me.Label1.Text = "Detalle el Error"
        '
        'Button_Guardar
        '
        Me.Button_Guardar.Image = CType(resources.GetObject("Button_Guardar.Image"), System.Drawing.Image)
        Me.Button_Guardar.Location = New System.Drawing.Point(399, 488)
        Me.Button_Guardar.Name = "Button_Guardar"
        Me.Button_Guardar.Size = New System.Drawing.Size(152, 43)
        Me.Button_Guardar.TabIndex = 371
        Me.Button_Guardar.Tag = "tx"
        Me.Button_Guardar.Text = "Informar Error al Administrador"
        Me.Button_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_Guardar.UseVisualStyleBackColor = True
        '
        'RichTextBox_Mensaje
        '
        Me.RichTextBox_Mensaje.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Mensaje.Location = New System.Drawing.Point(160, 285)
        Me.RichTextBox_Mensaje.Name = "RichTextBox_Mensaje"
        Me.RichTextBox_Mensaje.Size = New System.Drawing.Size(396, 197)
        Me.RichTextBox_Mensaje.TabIndex = 370
        Me.RichTextBox_Mensaje.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 16)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = " Comuníquese Con El Administrador de La Aplicación"
        '
        'Label_Error
        '
        Me.Label_Error.AutoSize = True
        Me.Label_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Error.Location = New System.Drawing.Point(42, 9)
        Me.Label_Error.Name = "Label_Error"
        Me.Label_Error.Size = New System.Drawing.Size(479, 16)
        Me.Label_Error.TabIndex = 365
        Me.Label_Error.Text = "Ha Ocurrido un Error, Inténtelo Nuevamente, si el problema Persiste "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 368
        Me.PictureBox2.TabStop = False
        '
        'RichTextBox_Error
        '
        Me.RichTextBox_Error.Enabled = False
        Me.RichTextBox_Error.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Error.Location = New System.Drawing.Point(160, 49)
        Me.RichTextBox_Error.Name = "RichTextBox_Error"
        Me.RichTextBox_Error.Size = New System.Drawing.Size(396, 214)
        Me.RichTextBox_Error.TabIndex = 367
        Me.RichTextBox_Error.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 366
        Me.PictureBox1.TabStop = False
        '
        'Form_Error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(563, 539)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Error"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Error"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Guardar As System.Windows.Forms.Button
    Friend WithEvents RichTextBox_Mensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_Error As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox_Error As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
