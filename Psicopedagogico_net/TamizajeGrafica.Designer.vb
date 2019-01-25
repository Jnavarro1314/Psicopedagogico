<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TamizajeGrafica
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TamizajeGrafica))
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CBFactor = New System.Windows.Forms.ComboBox()
        Me.DUpGrafica = New System.Windows.Forms.DomainUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGraficar = New System.Windows.Forms.Button()
        Me.GridGrafica = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBPlantel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBGrupo = New System.Windows.Forms.ComboBox()
        Me.LabelFactor = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip_Titulo.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridGrafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(748, 44)
        Me.ToolStrip_Titulo.TabIndex = 91
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(539, 41)
        Me.ToolStripLabel1.Text = "Gráfica de Resultados de Tamizaje de Riesgo Psicosocial UCEM" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(4, 10)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(518, 220)
        Me.Chart1.TabIndex = 92
        Me.Chart1.Text = "Chart1"
        '
        'CBFactor
        '
        Me.CBFactor.FormattingEnabled = True
        Me.CBFactor.Items.AddRange(New Object() {"RIESGO SUICIDA", "DEPRESION", "ANSIEDAD", "VIOLENCIA EN ADOLESCENTES", "CONSUMO DE SUSTANCIAS", "CONDUCTAS ALIM. DE RIESGO"})
        Me.CBFactor.Location = New System.Drawing.Point(98, 182)
        Me.CBFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.CBFactor.Name = "CBFactor"
        Me.CBFactor.Size = New System.Drawing.Size(270, 27)
        Me.CBFactor.TabIndex = 94
        '
        'DUpGrafica
        '
        Me.DUpGrafica.Items.Add("COLUMNAS")
        Me.DUpGrafica.Items.Add("PUNTOS")
        Me.DUpGrafica.Items.Add("LINEAS")
        Me.DUpGrafica.Items.Add("CIRCULAR")
        Me.DUpGrafica.Items.Add("DONA")
        Me.DUpGrafica.Items.Add("BARRAS")
        Me.DUpGrafica.Location = New System.Drawing.Point(11, 49)
        Me.DUpGrafica.Margin = New System.Windows.Forms.Padding(4)
        Me.DUpGrafica.Name = "DUpGrafica"
        Me.DUpGrafica.Size = New System.Drawing.Size(165, 27)
        Me.DUpGrafica.TabIndex = 95
        Me.DUpGrafica.Text = "---- Selecciona ----"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Resultados"
        '
        'BtnGraficar
        '
        Me.BtnGraficar.Image = CType(resources.GetObject("BtnGraficar.Image"), System.Drawing.Image)
        Me.BtnGraficar.Location = New System.Drawing.Point(16, 30)
        Me.BtnGraficar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGraficar.Name = "BtnGraficar"
        Me.BtnGraficar.Size = New System.Drawing.Size(44, 37)
        Me.BtnGraficar.TabIndex = 97
        Me.BtnGraficar.UseVisualStyleBackColor = True
        '
        'GridGrafica
        '
        Me.GridGrafica.AllowUserToAddRows = False
        Me.GridGrafica.AllowUserToDeleteRows = False
        Me.GridGrafica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridGrafica.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GridGrafica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridGrafica.Location = New System.Drawing.Point(387, 77)
        Me.GridGrafica.Margin = New System.Windows.Forms.Padding(4)
        Me.GridGrafica.Name = "GridGrafica"
        Me.GridGrafica.ReadOnly = True
        Me.GridGrafica.Size = New System.Drawing.Size(348, 165)
        Me.GridGrafica.TabIndex = 98
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 19)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "GRUPO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "PLANTEL:"
        '
        'CBPlantel
        '
        Me.CBPlantel.DropDownHeight = 160
        Me.CBPlantel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPlantel.FormattingEnabled = True
        Me.CBPlantel.IntegralHeight = False
        Me.CBPlantel.Location = New System.Drawing.Point(98, 114)
        Me.CBPlantel.Name = "CBPlantel"
        Me.CBPlantel.Size = New System.Drawing.Size(270, 27)
        Me.CBPlantel.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "FACTOR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "TIPO DE GRAFICA:"
        '
        'CBGrupo
        '
        Me.CBGrupo.FormattingEnabled = True
        Me.CBGrupo.Location = New System.Drawing.Point(98, 147)
        Me.CBGrupo.Name = "CBGrupo"
        Me.CBGrupo.Size = New System.Drawing.Size(270, 27)
        Me.CBGrupo.TabIndex = 105
        '
        'LabelFactor
        '
        Me.LabelFactor.AutoSize = True
        Me.LabelFactor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFactor.Location = New System.Drawing.Point(383, 54)
        Me.LabelFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFactor.Name = "LabelFactor"
        Me.LabelFactor.Size = New System.Drawing.Size(61, 19)
        Me.LabelFactor.TabIndex = 106
        Me.LabelFactor.Text = "FACTOR"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Location = New System.Drawing.Point(208, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 238)
        Me.Panel1.TabIndex = 107
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(15, 30)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(44, 37)
        Me.BtnImprimir.TabIndex = 98
        Me.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "GRAFICAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "IMPRIMIR"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DUpGrafica)
        Me.Panel2.Location = New System.Drawing.Point(10, 260)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 238)
        Me.Panel2.TabIndex = 108
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.BtnImprimir)
        Me.Panel4.Location = New System.Drawing.Point(97, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(79, 73)
        Me.Panel4.TabIndex = 110
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BtnGraficar)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(11, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(79, 73)
        Me.Panel3.TabIndex = 109
        '
        'TamizajeGrafica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(748, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelFactor)
        Me.Controls.Add(Me.CBGrupo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBPlantel)
        Me.Controls.Add(Me.GridGrafica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBFactor)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TamizajeGrafica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TamizajeGrafica"
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridGrafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip_Titulo As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents CBFactor As ComboBox
    Friend WithEvents DUpGrafica As DomainUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGraficar As Button
    Friend WithEvents GridGrafica As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBPlantel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBGrupo As ComboBox
    Friend WithEvents LabelFactor As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
End Class
