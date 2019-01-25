<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.Panel_DatosPersonales = New System.Windows.Forms.Panel()
        Me.Label_Plantel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_Usuario = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox_DiscosDuros = New System.Windows.Forms.RichTextBox()
        Me.Label_Serie = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_SO = New System.Windows.Forms.Label()
        Me.Label_IPPublica = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_IPLocal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_Tarjeta_Madre = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label_Ram = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_Procesador = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_Nombre = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_Guardar = New System.Windows.Forms.Button()
        Me.Panel_DatosPersonales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_DatosPersonales
        '
        Me.Panel_DatosPersonales.BackColor = System.Drawing.SystemColors.Window
        Me.Panel_DatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_Plantel)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label3)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_Usuario)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label5)
        Me.Panel_DatosPersonales.Controls.Add(Me.Button_Guardar)
        Me.Panel_DatosPersonales.Controls.Add(Me.GroupBox1)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_Serie)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label2)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_SO)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_IPPublica)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label6)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_IPLocal)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label9)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_Tarjeta_Madre)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label11)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label13)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_Ram)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label7)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_Procesador)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label10)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label_Nombre)
        Me.Panel_DatosPersonales.Controls.Add(Me.Label12)
        Me.Panel_DatosPersonales.Location = New System.Drawing.Point(4, 34)
        Me.Panel_DatosPersonales.Name = "Panel_DatosPersonales"
        Me.Panel_DatosPersonales.Size = New System.Drawing.Size(681, 309)
        Me.Panel_DatosPersonales.TabIndex = 84
        Me.Panel_DatosPersonales.Tag = "panel"
        '
        'Label_Plantel
        '
        Me.Label_Plantel.AutoSize = True
        Me.Label_Plantel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Plantel.Location = New System.Drawing.Point(141, 239)
        Me.Label_Plantel.Name = "Label_Plantel"
        Me.Label_Plantel.Size = New System.Drawing.Size(21, 19)
        Me.Label_Plantel.TabIndex = 438
        Me.Label_Plantel.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(81, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 437
        Me.Label3.Text = "Plantel"
        '
        'Label_Usuario
        '
        Me.Label_Usuario.AutoSize = True
        Me.Label_Usuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Usuario.Location = New System.Drawing.Point(141, 266)
        Me.Label_Usuario.Name = "Label_Usuario"
        Me.Label_Usuario.Size = New System.Drawing.Size(21, 19)
        Me.Label_Usuario.TabIndex = 436
        Me.Label_Usuario.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(76, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 435
        Me.Label5.Text = "Usuario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox_DiscosDuros)
        Me.GroupBox1.Location = New System.Drawing.Point(485, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 243)
        Me.GroupBox1.TabIndex = 433
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informnacion de Discos Duros"
        '
        'RichTextBox_DiscosDuros
        '
        Me.RichTextBox_DiscosDuros.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBox_DiscosDuros.Name = "RichTextBox_DiscosDuros"
        Me.RichTextBox_DiscosDuros.Size = New System.Drawing.Size(179, 222)
        Me.RichTextBox_DiscosDuros.TabIndex = 431
        Me.RichTextBox_DiscosDuros.Text = ""
        '
        'Label_Serie
        '
        Me.Label_Serie.AutoSize = True
        Me.Label_Serie.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Serie.Location = New System.Drawing.Point(141, 183)
        Me.Label_Serie.Name = "Label_Serie"
        Me.Label_Serie.Size = New System.Drawing.Size(21, 19)
        Me.Label_Serie.TabIndex = 430
        Me.Label_Serie.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(39, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 429
        Me.Label2.Text = "Numero Serie"
        '
        'Label_SO
        '
        Me.Label_SO.AutoSize = True
        Me.Label_SO.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_SO.Location = New System.Drawing.Point(141, 210)
        Me.Label_SO.Name = "Label_SO"
        Me.Label_SO.Size = New System.Drawing.Size(21, 19)
        Me.Label_SO.TabIndex = 428
        Me.Label_SO.Text = "..."
        '
        'Label_IPPublica
        '
        Me.Label_IPPublica.AutoSize = True
        Me.Label_IPPublica.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_IPPublica.Location = New System.Drawing.Point(141, 129)
        Me.Label_IPPublica.Name = "Label_IPPublica"
        Me.Label_IPPublica.Size = New System.Drawing.Size(21, 19)
        Me.Label_IPPublica.TabIndex = 427
        Me.Label_IPPublica.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(63, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 426
        Me.Label6.Text = "IP Publica"
        '
        'Label_IPLocal
        '
        Me.Label_IPLocal.AutoSize = True
        Me.Label_IPLocal.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_IPLocal.Location = New System.Drawing.Point(141, 102)
        Me.Label_IPLocal.Name = "Label_IPLocal"
        Me.Label_IPLocal.Size = New System.Drawing.Size(21, 19)
        Me.Label_IPLocal.TabIndex = 425
        Me.Label_IPLocal.Text = "..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(76, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 19)
        Me.Label9.TabIndex = 424
        Me.Label9.Text = "IP Local"
        '
        'Label_Tarjeta_Madre
        '
        Me.Label_Tarjeta_Madre.AutoSize = True
        Me.Label_Tarjeta_Madre.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Tarjeta_Madre.Location = New System.Drawing.Point(141, 156)
        Me.Label_Tarjeta_Madre.Name = "Label_Tarjeta_Madre"
        Me.Label_Tarjeta_Madre.Size = New System.Drawing.Size(21, 19)
        Me.Label_Tarjeta_Madre.TabIndex = 423
        Me.Label_Tarjeta_Madre.Text = "..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(35, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 19)
        Me.Label11.TabIndex = 422
        Me.Label11.Text = "Tarjeta Madre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(6, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 19)
        Me.Label13.TabIndex = 421
        Me.Label13.Text = "Siatema Operativo"
        '
        'Label_Ram
        '
        Me.Label_Ram.AutoSize = True
        Me.Label_Ram.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Ram.Location = New System.Drawing.Point(141, 48)
        Me.Label_Ram.Name = "Label_Ram"
        Me.Label_Ram.Size = New System.Drawing.Size(21, 19)
        Me.Label_Ram.TabIndex = 420
        Me.Label_Ram.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(35, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 419
        Me.Label7.Text = "Memoria Ram"
        '
        'Label_Procesador
        '
        Me.Label_Procesador.AutoSize = True
        Me.Label_Procesador.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Procesador.Location = New System.Drawing.Point(141, 75)
        Me.Label_Procesador.Name = "Label_Procesador"
        Me.Label_Procesador.Size = New System.Drawing.Size(21, 19)
        Me.Label_Procesador.TabIndex = 418
        Me.Label_Procesador.Text = "..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(54, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 417
        Me.Label10.Text = "Procesador"
        '
        'Label_Nombre
        '
        Me.Label_Nombre.AutoSize = True
        Me.Label_Nombre.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label_Nombre.Location = New System.Drawing.Point(141, 21)
        Me.Label_Nombre.Name = "Label_Nombre"
        Me.Label_Nombre.Size = New System.Drawing.Size(21, 19)
        Me.Label_Nombre.TabIndex = 416
        Me.Label_Nombre.Text = "..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(54, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 19)
        Me.Label12.TabIndex = 415
        Me.Label12.Text = "Nombre PC"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(681, 25)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "DATOS CPU"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_Guardar
        '
        Me.Button_Guardar.Image = CType(resources.GetObject("Button_Guardar.Image"), System.Drawing.Image)
        Me.Button_Guardar.Location = New System.Drawing.Point(539, 252)
        Me.Button_Guardar.Name = "Button_Guardar"
        Me.Button_Guardar.Size = New System.Drawing.Size(119, 38)
        Me.Button_Guardar.TabIndex = 434
        Me.Button_Guardar.Tag = ""
        Me.Button_Guardar.Text = "Inventariar"
        Me.Button_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_Guardar.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(689, 348)
        Me.Controls.Add(Me.Panel_DatosPersonales)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.Panel_DatosPersonales.ResumeLayout(False)
        Me.Panel_DatosPersonales.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_DatosPersonales As System.Windows.Forms.Panel
    Friend WithEvents Label_Plantel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label_Usuario As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button_Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox_DiscosDuros As System.Windows.Forms.RichTextBox
    Friend WithEvents Label_Serie As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_SO As System.Windows.Forms.Label
    Friend WithEvents Label_IPPublica As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_IPLocal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label_Tarjeta_Madre As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label_Ram As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label_Procesador As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label_Nombre As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
