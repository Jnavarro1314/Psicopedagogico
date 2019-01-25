<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sintesis
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fecha2 = New System.Windows.Forms.TextBox()
        Me.txt_fecha1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid_sintesis = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_periodo = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip_Titulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_sintesis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(1292, 44)
        Me.ToolStrip_Titulo.TabIndex = 66
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(283, 41)
        Me.ToolStripLabel1.Text = "CUADRO DE SINTESIS SEMANAL"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(8, 154)
        Me.MonthCalendar1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar1.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 67
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BtnPrint)
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_fecha2)
        Me.Panel1.Controls.Add(Me.txt_fecha1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Location = New System.Drawing.Point(1014, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 537)
        Me.Panel1.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 114)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "INSTRUCIONES:  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selecciona una fecha en el calendario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "indicando el inicio de pe" & _
    "riodo, que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "consta de 7 dias a partir de la fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seleccionada. A continuacio" & _
    "n da clic " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en el Boton: 'Buscar'"
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = Global.Psicopedagogico_net.My.Resources.Resources.print
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(12, 477)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(104, 39)
        Me.BtnPrint.TabIndex = 74
        Me.BtnPrint.Text = "Imprimir"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Image = Global.Psicopedagogico_net.My.Resources.Resources.apply
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(163, 477)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(93, 39)
        Me.btn_ok.TabIndex = 73
        Me.btn_ok.Text = "Buscar"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 19)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "FIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "INICIO"
        '
        'txt_fecha2
        '
        Me.txt_fecha2.Enabled = False
        Me.txt_fecha2.Location = New System.Drawing.Point(66, 417)
        Me.txt_fecha2.Name = "txt_fecha2"
        Me.txt_fecha2.Size = New System.Drawing.Size(190, 27)
        Me.txt_fecha2.TabIndex = 70
        Me.txt_fecha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fecha1
        '
        Me.txt_fecha1.Enabled = False
        Me.txt_fecha1.Location = New System.Drawing.Point(66, 384)
        Me.txt_fecha1.Name = "txt_fecha1"
        Me.txt_fecha1.Size = New System.Drawing.Size(190, 27)
        Me.txt_fecha1.TabIndex = 69
        Me.txt_fecha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "PERIODO"
        '
        'grid_sintesis
        '
        Me.grid_sintesis.AllowUserToAddRows = False
        Me.grid_sintesis.AllowUserToDeleteRows = False
        Me.grid_sintesis.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grid_sintesis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_sintesis.BackgroundColor = System.Drawing.Color.White
        Me.grid_sintesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_sintesis.Location = New System.Drawing.Point(8, 97)
        Me.grid_sintesis.Name = "grid_sintesis"
        Me.grid_sintesis.ReadOnly = True
        Me.grid_sintesis.Size = New System.Drawing.Size(1000, 487)
        Me.grid_sintesis.TabIndex = 70
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(54, 8)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(17, 19)
        Me.lbl_total.TabIndex = 83
        Me.lbl_total.Text = "_"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "TOTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "PERIODO:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbl_total)
        Me.Panel2.Location = New System.Drawing.Point(8, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(506, 33)
        Me.Panel2.TabIndex = 86
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lbl_periodo)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(520, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(488, 33)
        Me.Panel3.TabIndex = 87
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(79, 8)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(17, 19)
        Me.lbl_periodo.TabIndex = 86
        Me.lbl_periodo.Text = "_"
        Me.lbl_periodo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Lavender
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1292, 22)
        Me.StatusStrip1.TabIndex = 88
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Sintesis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1292, 609)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.grid_sintesis)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Sintesis"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuadro de Síntesis"
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid_sintesis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid_sintesis As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
