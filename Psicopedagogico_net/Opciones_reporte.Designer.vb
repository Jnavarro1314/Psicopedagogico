<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones_reporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opciones_reporte))
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_solicita = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_recibe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_recib_puesto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_soli_puesto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Reporte = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip_Titulo.SuspendLayout()
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(449, 40)
        Me.ToolStrip_Titulo.TabIndex = 15
        Me.ToolStrip_Titulo.Text = "Opciones de Reporte"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(189, 37)
        Me.ToolStripLabel1.Text = "Opciones de Reporte"
        '
        'txt_folio
        '
        Me.txt_folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_folio.Location = New System.Drawing.Point(198, 67)
        Me.txt_folio.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_folio.MaxLength = 20
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(192, 27)
        Me.txt_folio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "FOLIO DEL ALUMNO"
        '
        'txt_solicita
        '
        Me.txt_solicita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_solicita.Location = New System.Drawing.Point(117, 129)
        Me.txt_solicita.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_solicita.MaxLength = 50
        Me.txt_solicita.Name = "txt_solicita"
        Me.txt_solicita.Size = New System.Drawing.Size(297, 27)
        Me.txt_solicita.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "SOLICITA"
        '
        'txt_recibe
        '
        Me.txt_recibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_recibe.Location = New System.Drawing.Point(117, 207)
        Me.txt_recibe.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_recibe.MaxLength = 50
        Me.txt_recibe.Name = "txt_recibe"
        Me.txt_recibe.Size = New System.Drawing.Size(297, 27)
        Me.txt_recibe.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "RECIBE"
        '
        'txt_recib_puesto
        '
        Me.txt_recib_puesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_recib_puesto.Location = New System.Drawing.Point(117, 241)
        Me.txt_recib_puesto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_recib_puesto.MaxLength = 50
        Me.txt_recib_puesto.Name = "txt_recib_puesto"
        Me.txt_recib_puesto.Size = New System.Drawing.Size(297, 27)
        Me.txt_recib_puesto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 244)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "PUESTO"
        '
        'txt_soli_puesto
        '
        Me.txt_soli_puesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_soli_puesto.Location = New System.Drawing.Point(117, 163)
        Me.txt_soli_puesto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_soli_puesto.MaxLength = 50
        Me.txt_soli_puesto.Name = "txt_soli_puesto"
        Me.txt_soli_puesto.Size = New System.Drawing.Size(297, 27)
        Me.txt_soli_puesto.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "PUESTO"
        '
        'Btn_Reporte
        '
        Me.Btn_Reporte.Image = Global.Psicopedagogico_net.My.Resources.Resources.go
        Me.Btn_Reporte.Location = New System.Drawing.Point(198, 289)
        Me.Btn_Reporte.Name = "Btn_Reporte"
        Me.Btn_Reporte.Size = New System.Drawing.Size(102, 40)
        Me.Btn_Reporte.TabIndex = 6
        Me.Btn_Reporte.Text = "Generar"
        Me.Btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Reporte.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Opciones_reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 349)
        Me.Controls.Add(Me.txt_soli_puesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_solicita)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.txt_recib_puesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_Reporte)
        Me.Controls.Add(Me.txt_recibe)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Opciones_reporte"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Reporte"
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_solicita As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_recibe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_recib_puesto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_soli_puesto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_Reporte As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
