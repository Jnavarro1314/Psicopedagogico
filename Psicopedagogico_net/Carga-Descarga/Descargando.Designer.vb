<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Descargando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Descargando))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar_Cargado = New System.Windows.Forms.ProgressBar()
        Me.Label_Progreso = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(109, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar_Cargado
        '
        Me.ProgressBar_Cargado.Location = New System.Drawing.Point(11, 8)
        Me.ProgressBar_Cargado.Name = "ProgressBar_Cargado"
        Me.ProgressBar_Cargado.Size = New System.Drawing.Size(373, 31)
        Me.ProgressBar_Cargado.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar_Cargado.TabIndex = 24
        '
        'Label_Progreso
        '
        Me.Label_Progreso.AutoSize = True
        Me.Label_Progreso.Location = New System.Drawing.Point(87, 42)
        Me.Label_Progreso.Name = "Label_Progreso"
        Me.Label_Progreso.Size = New System.Drawing.Size(220, 13)
        Me.Label_Progreso.TabIndex = 23
        Me.Label_Progreso.Text = "Por favor espere a que se cargue su solicitud"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Descargando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar_Cargado)
        Me.Controls.Add(Me.Label_Progreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Descargando"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descargando..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar_Cargado As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_Progreso As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
